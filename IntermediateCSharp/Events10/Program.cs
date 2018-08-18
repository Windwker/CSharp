using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events10
{
    class Program
    {
        static void Main(string[] args)
        {
            int reader = 0;
            School school = new School(){ Name = "San Pedro Apostol" };
            SchoolManager manager = new SchoolManager(school);
            NotificationManager notificationManager = new NotificationManager();
            ClassRoomViewModel classRoomView = new ClassRoomViewModel();
            manager.ClassStarted += notificationManager.OnClassStarted;
            classRoomView.StudentAdded += notificationManager.OnStudentAdded;


            System.Console.WriteLine(school.Name);
            System.Console.WriteLine("Options: ");
            System.Console.WriteLine("1- Add Student 2- Start Classes");
            reader = int.Parse(System.Console.ReadLine());


            while (reader == 1)
            {
                var age = 0;
                var name = "";
                System.Console.WriteLine("Insert name of the student: ");
                name = System.Console.ReadLine();
                System.Console.WriteLine("Insert age of the student: ");
                age = int.Parse(System.Console.ReadLine());

                classRoomView.AddStudent(new Students {Name = name, Age = age, School = school }, school);
                System.Console.WriteLine("1- Add Student 2- Start Classes");
                reader = int.Parse(System.Console.ReadLine());
            }
            
           

            
        }
    }

}
