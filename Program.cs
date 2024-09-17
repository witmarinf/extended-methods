using System.ComponentModel;
using extended_methods.Model;


namespace extended_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object text = new Object();
            Object text1 = new Object();

            Console.WriteLine($"reference: {Object.ReferenceEquals(text,text1)}");
            Console.WriteLine(text.ToString());
            Console.WriteLine(text1==text);
            Console.WriteLine(text1.Equals(text));

            Point p1 = new Point();
            Point p2 = new Point();

            p1.X = 1;
            p1.Y = 1;
            p2.X = 1;
            p2.Y = 1;

            Console.WriteLine($"porownanie: {p1.Equals(p2)}");
            Console.WriteLine($"porownanie: {p1==p2}");

            Console.WriteLine($"referenceEquals: {Point.ReferenceEquals(p1, p2)}");
             
        }
    }
}