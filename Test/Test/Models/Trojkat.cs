namespace Test.Models
{
    public class Trojkat
    {
        public int a {  get; set; }
        public int b { get; set; }
        public int c { get; set; }
        /*public Trojkat(int _a, int _b, int _c)
        {
            a = _a; 
            b = _b; 
            c = _c;
        }*/
        public int PP()
        {
            return (a * b) / 2;
        }
        public int Obw()
        {
            return a + b + c;
        }
    }
}
