namespace Test.Models
{
    public class Szesciokat
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public double PPSzesciokat ()
        {
            return ((3 * Math.Pow(a,2)) * Math.Sqrt(3)) / 2;
        }
        public double ObwSzesciokat ()
        {
            return 6 * a;
        }
    }
}
