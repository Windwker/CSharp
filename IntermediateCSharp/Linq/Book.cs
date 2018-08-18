namespace Linq
{
    public class Book
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Book(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
