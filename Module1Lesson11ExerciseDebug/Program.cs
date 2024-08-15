namespace Module1Lesson11ExerciseDebug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug");

            int a = 25;
            int b = 5;

            double product = a * b;

            Console.WriteLine(product);

            double quotient = a / b;

            Console.WriteLine(quotient);

            SumSum sumObject = new SumSum();
            double sumResult = sumObject.CalculateSum();

            Console.WriteLine(sumResult);
        }
    }
}
