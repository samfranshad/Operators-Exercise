namespace OperatorExercise
{
    public class Program
    {
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
        }
    }
}
