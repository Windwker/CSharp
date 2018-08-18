using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Juan = new Person("Juan");
            //var Persona2 = new Person();
            //Console.WriteLine(  Juan.Salutate());
            //Console.WriteLine(Persona2.Salutate());
            //var ordenes = new orders();
            //Juan.Ordenes.Add(ordenes);
            //int a = 1;
            //Juan.MyMethod(ref a);
            //Console.WriteLine("TEST" + a);

            //UsePoints();
            // UseCustomer();
            //UsePerson();
            //UsePersons2();
            //UseHttpCookie();
            //Exercise1();
            //Exercise2();
            //Inheritance();
            //Composition();
            //Salary();
            DrawShapes();
            
        }

        static void DrawShapes()
        {
            var circle = new AbstractClass.Circle();
            circle.Ratio = 20;
            circle.Size = 400;
            circle.Draw();
            var rectangle1 = new AbstractClass.Rectangle("Equilatero", "Cuadrado1");
            var rectangle2 = new AbstractClass.Rectangle("Equilatero", "Irreal");
            var rectangle3 = new AbstractClass.Rectangle("Equilatero", "Eliminado");
            List<AbstractClass.Shape> shapes = new List<AbstractClass.Shape>();
            shapes.Add(circle);
            shapes.Add(rectangle1);
            shapes.Add(rectangle2);
            shapes.Add(rectangle3);

            var canvas = new AbstractClass.Canvas();
            canvas.DrawShape(shapes);

        }

        static void Salary()
        {
            var jefe = new Polimorphism.Boss();
            var trainee = new Polimorphism.Trainee();
            List < Polimorphism.Employee > employees = new List<Polimorphism.Employee>();
            employees.Add(new Polimorphism.Boss());
            employees.Add(new Polimorphism.Trainee());
            employees.Add(new Polimorphism.Trainee());
            employees.Add(new Polimorphism.Trainee());
            employees.Add(new Polimorphism.Trainee());
            var salarycalculator = new Polimorphism.SalaryCalculator();
            salarycalculator.CalculateSalary(employees);
        }

        static void Composition()
        {
            var dbMigrator = new Composition.DbMigrator(new IntermediateCSharp.Composition.Logger());
            dbMigrator.Migrate();
            var logger = new Composition.Logger();
            var installer = new Composition.Installer(logger);
            installer.Install();
        }

        static void Inheritance()
        {
            var text = new Inheritance.Text();
            text.Width = 100;
            text.Copy();
            Console.WriteLine(text.Width);
        }


        static void Exercise2()
        {
            List<Classes_Exercise.Post> posts = new List<Classes_Exercise.Post>();

            var Post = new Classes_Exercise.Post("Test", "Test Description");
            Post.UpVote();
            Post.UpVote(); Post.UpVote(); Post.UpVote(); Post.UpVote();
            Console.WriteLine("Title:{0},Description:{1},Votes:{2},Created:{3}",Post.Title,Post.Description,Post.Votes,Post.CreationTime);
        }

        static void Exercise1()
        {
            var watch = new Classes_Exercise.StopWatch();
            
            string input = "";
            int watchstarted = 0;

            while (input !="Exit")
            {
                Console.Write("Write Start to start the StopWatch, Stop to stop or Exit to exit: ");
                input = Console.ReadLine();
                
                switch (input)
                {
                    case "Start":
                        if (watchstarted==0)
                        {
                            watch.Start(DateTime.Now);
                            watchstarted = 1;
                        }
                        else
                        {
                            throw new InvalidOperationException("Stop the watch First!!");
                        }
                        break;

                    case "Stop":
                        watch.Stop();
                        watchstarted = 0;
                        break;

                    
                }
            }


            
        }

        static void UseHttpCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Javier";
            Console.WriteLine(cookie["name"]);
        }

        static void UsePersons2()
        {
            var persona = new Persons2(new DateTime(1980, 2, 14));
            
            Console.WriteLine(persona.Age);
        }


        static void UsePerson()
        {
            var person1 = new Persons();
            person1.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person1.GetBirthday());
        }



        static void UseCustomer()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            calculator.Add(1, 2,3,4);
            calculator.Add(1, 2, 3, 5);
            calculator.Add(1, 2, 3, 6);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at({0},{1})", point.x, point.y);
                point.Move(100, 200);
                Console.WriteLine("Point is at({0},{1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");

            }
        }
    }

    //public class Persons
    //{
        
    //    public string Name;
    //    public List<orders> Ordenes;
    //    public Persons()
    //    {
    //        Ordenes = new List<orders>();
    //        Name = "Undefined name";
    //    }

    //    public Persons(string name)
    //        : this()
    //    {
            
    //        this.Name = name;



    //    } 

    //   public String Salutate()
    //    {
    //        return "Hello!" + Name;
    //    }


    //    public void MyMethod(ref int a)
    //    {
    //        a += 2;
    //    }

        
    //}

    public class orders
    {

    }

    
}
