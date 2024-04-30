namespace OperatorExercise
{
    public class Program
    {

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int add = a + b;
            int subtract = a - b;
            int multiply = a * b;

            int c = 20;
            int d = 2;

            int quotient = c / d;
            int remainder = c % d;

            Console.WriteLine($"{c}/{d} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            double circleArea = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {circleArea}");
        }
    }
}
