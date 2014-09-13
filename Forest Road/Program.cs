using System;

namespace Lulin_forest_road
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int dotsPreFirst = 0;
            int dotsPostFirst = 0;
            int dotsPreSecond = n-2;
            int dotsPostSecond = 1;

            for (int i = n; i > 0; i--)
            {

                dotsPostFirst = i - 1;

                Console.Write(new string('.', dotsPreFirst));
                Console.Write("*");
                Console.Write(new string('.', dotsPostFirst));
                Console.WriteLine();
                dotsPreFirst++;
                dotsPostFirst--;
            }
            for (int j = 1; j <= n-1; j++)
            {
                if (j != 1)
                {
                    dotsPreSecond--;
                }
                
                dotsPostSecond = j;

                Console.Write(new string('.', dotsPreSecond));
                Console.Write("*");
                Console.Write(new string('.', dotsPostSecond));
                Console.WriteLine();
                dotsPostSecond++;
            }
        }
    }
}
