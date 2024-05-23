namespace Test.Models
{
    public class Trojkat
    {
        public double a {  get; set; }
        public double b { get; set; }
        public double c { get; set; }        

        /*public Trojkat(int _a, int _b, int _c)
        {
            a = _a; 
            b = _b; 
            c = _c;
        }*/
        public double PP()
        {
            return (a * b) / 2;
        }
        public double Obw()
        {
            return a + b + c;
        }
    }
}
