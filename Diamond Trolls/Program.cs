using System;

namespace Diamond_Trolls
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int StarsFirstLine = n;
            int firstDots = (n / 2) + 1;
            int dotsInsideDiamondFirst = n / 2;
            int fullStarLine = (n * 2) + 1;
            int dotsInsideDiamondSecond = n - 2;

            for (int i = firstDots; i > 0; i--)
            {
                if (i== firstDots)
                {
                Console.Write(new string ('.', firstDots));
                Console.Write(new string ('*', n));
                Console.Write(new string('.', firstDots));
                Console.WriteLine();
                }
                else
                {
                    firstDots--;
                    Console.Write(new string ('.', firstDots));
                    Console.Write("*");
                    Console.Write(new string ('.', dotsInsideDiamondFirst));
                    Console.Write("*");
                    Console.Write(new string('.', dotsInsideDiamondFirst));
                    Console.Write("*");
                    Console.Write(new string('.', firstDots));
                    Console.WriteLine();
                    dotsInsideDiamondFirst++;
                }
            }
            Console.WriteLine(new string ('*', fullStarLine));

            for (int i = 1; i < n; i++)
            {
                Console.Write(new string ('.', i));
                Console.Write("*");
                Console.Write(new string ('.', dotsInsideDiamondSecond));
                Console.Write("*");
                Console.Write(new string('.', dotsInsideDiamondSecond));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine();
                dotsInsideDiamondSecond--;
            }
            Console.Write(new string ('.', n));
            Console.Write("*");
            Console.Write(new string('.', n));
        }
    }
}

