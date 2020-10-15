using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            ShowAnswer(CalcuateFactorial(num));
        }

        static string CalcuateFactorial(int num)
        {
            int factorial = 1;
            
            if (num == 0)
            {
                factorial = 1;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }
            }

            return Convert.ToString(factorial);
        }

        static void ShowAnswer(string factorial)
        {
            int factLength = factorial.Length;
            Console.Write("╔");
            for (int i = 0; i <= factLength + 1; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╗");

            Console.WriteLine("║ " + factorial + " ║");

            Console.Write("╚");
            for (int i = 0; i <= factLength + 1; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╝");
        }
    }
}
