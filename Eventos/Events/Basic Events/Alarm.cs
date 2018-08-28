namespace Basic_Events
{
    public class Alarm
    {
        public string Address { get; private set; }
        public Alarm(string address)
        {
            Address = address;
        }
    }
}
