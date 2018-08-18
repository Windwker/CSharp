using System;
namespace Events4
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

        

        public void OnMailSent(object source, EventArgs args)
        {
            System.Console.WriteLine(this + " Received the email" );
        }
    }



}
