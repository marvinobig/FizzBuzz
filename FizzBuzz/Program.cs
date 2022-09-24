namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            Console.Write("Enter the maximum number to check upto: ");
            int maxNum = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= maxNum; i++)
            {
                if (i % 3 == 0 & i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else Console.WriteLine(i);
            }

        }
    }
}