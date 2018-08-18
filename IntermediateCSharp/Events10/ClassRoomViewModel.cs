using System;
using System.Collections.Generic;
using System.Linq;

namespace Events10
{
    public class ClassRoomViewModel
    {

        public List<Students> StudentsList { get; private set; } = new List<Students>();
        public EventHandler<PersonEventArgs> StudentAdded;
        int counter = 0;
        public void AddStudent(Students students, School school)
        {
            
            counter = StudentsList.Where(b => b.School == school).Count();
            if (counter <2)
            {
                StudentsList.Add(students);
                counter = StudentsList.Where(b => b.School == school).Count();
                Console.WriteLine(counter + " students are in " + school.Name);
                OnStudentAdded(students);
            }
            else
            {
                Console.WriteLine("School is full");
            }


            
        }

        protected virtual void OnStudentAdded(Students students)
        {
            if (StudentAdded != null)
            {
                PersonEventArgs personEventArgs = new PersonEventArgs();
                personEventArgs.Name = students.Name;
                personEventArgs.Age = students.Age;
                StudentAdded(this, personEventArgs);
            }
        }

    }
}
