namespace Test.Models
{
    public class Robotnik
    {
        public Guid robotnikId { get; private set; } = Guid.NewGuid();
        public string name { get; set; }
        public int age { get; set; }              
    }
}
