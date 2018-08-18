using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var libro1 = new Book("Cortazar ilustrado", 6);
            var libro2 = new Book("Winnie the pooh", 18);
            var libro3 = new Book("La oruga", 1);
            var libro4 = new Book("Rambo", 55);
            var libro5 = new Book("Diccionario espanol", 3);
            var libro6 = new Book("Las tortugas ninja 2", 20);
            var libro7 = new Book("Harry Potter y la Piedra Filosofal", 5);
            var libro8 = new Book("La biografia de Elton John", 14);


            List<Book> books = new List<Book>();
            books.Add(libro1);
            books.Add(libro2);
            books.Add(libro3);
            books.Add(libro4);
            books.Add(libro5);
            books.Add(libro6);
            books.Add(libro7);
            books.Add(libro8);


            var onlyOneBook = books.Single(b => b.Name == "Las tortugas ninja 2");
            Console.WriteLine("Only One Book!");
            Console.WriteLine(onlyOneBook.Name + onlyOneBook.Price);

            var test = books.Where(p => p.Price < 10);
            Console.WriteLine("Test");

            foreach (var t in test)
            {
                Console.WriteLine(t.Name + " " + t.Price);
            };

            Console.WriteLine("EndTest");

            foreach (var book in books)
            {
                Console.WriteLine("Nombre: " + book.Name + ". Precio: " + book.Price);
            }

            // LINQ Extension Methods
            var cheapbooks = books.
                Where(b => b.Price < 10).
                OrderBy(x=> x.Name).
                Select(x=> x.Name);


            // LINQ Query Operators
            Console.WriteLine("LINQ QUERY OPERATOR");
            var test2 = from b in books
                        where b.Price < 10
                        orderby b.Price
                        select b.Name;

            foreach (var item in test2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Console.WriteLine("****");
            foreach (var book in cheapbooks)
            {
                Console.WriteLine("Nombre: " +book);
            }

            var costOfBooks = books.Sum(x => x.Price);
            var highestBook = books.Max(x => x.Price);
            var orderedBooks = books.OrderBy(b => b.Name);
            Console.WriteLine("SUM OF ALL: " + costOfBooks);
            Console.WriteLine("Most expensive Book: " + highestBook);
            Console.WriteLine("ORDERED BOOKS: " );
            foreach (var book in orderedBooks)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
