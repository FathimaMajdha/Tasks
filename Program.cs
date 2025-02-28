namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day2
            //Implement a program that checks if a given number is prime. Use a for loop to iterate through potential divisors.
            Console.Write("Enter a num:");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = num > 1;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "prime number" : "not a prime number");


            //diamond pattern
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }

            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    }
}
