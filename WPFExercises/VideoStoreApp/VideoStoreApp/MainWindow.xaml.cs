using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Members members = new Members();
        NotificationManager manager = new NotificationManager();
        public MainWindow()
        {
            DataContext = members;

            members.MemberAddedHandler += manager.OnMemberAdded;
            InitializeComponent();
         
           lvUsers.ItemsSource = members.List;
            
            


        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (members.Name != null && members.AuxName != null)
            {
                members.AddMember(members.Name, members.AuxName);
                
            }
            
            NameTextBox.Clear();
            MailTextBox.Clear();
            members.Name = null;
            members.AuxName = null;
           

        }
    }
}
