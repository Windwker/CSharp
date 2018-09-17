using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace VideoStoreApp
{
    public class Members : INotifyPropertyChanged
    {

        private string _name;
        private string _auxName;
        private string _emailAddress;


        public String Name
        {
            get { return _name; }
            set
            {
                if (Name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }


        public String AuxName
        {
            get { return _auxName; }
            set
            {
                if (AuxName != value)
                {
                    _auxName = value;
                    OnPropertyChanged("AuxName");
                }
            }
        }

        public String EMailAddress { get; set; }
        public ObservableCollection<Members> List = new ObservableCollection<Members>();

        public event PropertyChangedEventHandler PropertyChanged;

        public delegate void MemberAdded(object sender, EventArgs args);

        public event MemberAdded MemberAddedHandler;

        public void AddMember(String name, String eMailAddress)
        {
            
            
            List.Add(new Members(){Name = name, EMailAddress = eMailAddress });
            OnMemberAdded();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void OnMemberAdded()
        {
            if (MemberAddedHandler != null)
            {
                MemberAddedHandler(this, EventArgs.Empty);
            }
        }


        
        
    }

    public class NotificationManager
    {
        public void OnMemberAdded(object source, EventArgs args)
        {
            Console.WriteLine("TEST");
        }
    }
}
