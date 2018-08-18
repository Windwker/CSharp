namespace Events2
{
    public interface IAnimal
    {
        int Age { get;  set; }
        string Name { get; set; }
        void Walk();
        void Sleep();

    }
}
