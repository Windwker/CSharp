using System;
using System.Collections.Generic;

namespace Events10
{
    public class SchoolManager
    {


        School _school;
       
        public SchoolManager(School school)
        {
            _school = school;
        }


        
        public EventHandler<SchoolEventArgs> ClassStarted;



        public void StartClasses(School school)
        {
            OnClassStarted(school);
        }

        protected virtual void OnClassStarted(School school)
        {
            SchoolEventArgs schoolEventArgs = new SchoolEventArgs();
            if (ClassStarted != null)
            {
                schoolEventArgs.Name = school.Name;
                ClassStarted(this, schoolEventArgs);
            }
        }


    }
}
