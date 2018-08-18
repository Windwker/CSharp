namespace Events2
{
    public class Dog:IAnimal
    {
        public Dog(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age { get;  set; }
        public string Name { get;  set; }

        public  void Walk()
        {
            System.Console.WriteLine(Name+" is Walking"); ;
        }
        public  void Sleep()
        {
            System.Console.WriteLine(Name + " is sleeping"); 
        }
    }
}
