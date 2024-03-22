namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            var sum = a + b;
            var sub = a - b;
            var mult = a * b;
            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {mod}");
            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {sub}");
            Console.WriteLine($"{a} * {b} is {mult}");

            Console.WriteLine("Let's calculate the area of a circle, what is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());
            double Cir = AreaOfCircle(radius);
            Console.WriteLine($"The area of this circle is {Cir}");
        }
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        

    }
}
