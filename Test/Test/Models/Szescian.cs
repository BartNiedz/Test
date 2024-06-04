namespace Test.Models
{
    public class Szescian
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public double Obj ()
        { 
            return a * a * a; 
        }
    }
}
