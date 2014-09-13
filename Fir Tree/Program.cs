using System;

namespace Fir_Tree
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int stars = 1;

            for (int i = n; i > 1; i--)
            {
                int dots = i - 2;
                Console.Write(new string('.', dots));
                Console.Write(new string('*', stars));
                Console.Write(new string('.', dots));
                stars++;
                stars++;
                Console.WriteLine();
                if (i==2)
                {
                    Console.Write(new string('.', n-2));
                    Console.Write("*");
                    Console.Write(new string('.', n-2));
                }
                
            }
            
        }
    }
}



