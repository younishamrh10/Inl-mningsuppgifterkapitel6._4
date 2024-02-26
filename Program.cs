using System;

namespace Inlämningsuppgifterkapitel6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv basen till din potens");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv exponenten till din bas");
            int exponent = int.Parse(Console.ReadLine());
            Console.WriteLine("Svaret blir" + Metod(bas, exponent));
        }

        static double Metod(double bas, int exponent)
        {
            double svar = 1;
            for (int i = 0; i < exponent; i++)
            {
                svar *= bas;
            }

            return svar;
        }
    }
}