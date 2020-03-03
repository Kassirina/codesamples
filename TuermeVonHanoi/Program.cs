using System;

namespace TuermeVonHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            verschiebe(3);
            Console.Read();
        }

        private static void verschiebe(int scheibenanzahl, string a = "Startturm", string b = "Hilfsturm", string c = "Zielturm")
        {
            if (scheibenanzahl > 0)
            {
                verschiebe(scheibenanzahl - 1, a, c, b);
                Console.WriteLine("Verschiebe Scheibe vom {0} zum {1}.", a, c);
                verschiebe(scheibenanzahl - 1, b, a, c);
            }
        }
    }
}
