using System;

namespace Fizzbuzz
{
    class Program
    {
        /* Fizzbuzz ist ein Spiel bei dem von 1 bis 100 gezählt wird. 
         * Ist eine Zahl durch 3 teilbar, muss die Zahl durch das Wort "Fizz" ersetzt werden.
         * Ist eine Zahl durch 5 teilbar, muss die Zahl durch das Wort "Buzz" ersetzt werden.
         * Ist eine Zahl sowohl durch 3, akls auch durch 5 teilbar, muss die Zahl durch das Wort "Fizzbuzz" ersetzt werden.         
         */

        static void Main(string[] args)
        {
            string output;

            for (int i = 1; i <= 100; i++)
            {
                if (divisibleBy(i,3) && divisibleBy(i,5))
                {
                    output = "Fizzbuzz";
                }
                else if (divisibleBy(i, 3))
                {
                    output = "Fizz";
                }
                else if (divisibleBy(i, 5))
                {
                    output = "Buzz";
                }
                else
                {
                    output = i.ToString();
                }

                Console.Write("{0} ", output);                
            }
            Console.Read();
        }

        private static bool divisibleBy(int number, int divisor) => (number % divisor == 0);
    }
}
