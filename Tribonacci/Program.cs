using System;
using System.Numerics;

namespace tribonaci_test
{
    class Program
    {
        static void Main()
        {
            string input0 = Console.ReadLine();
            BigInteger a = BigInteger.Parse(input0);
            string input1 = Console.ReadLine();
            BigInteger b = BigInteger.Parse(input1);
            string input2 = Console.ReadLine();
            BigInteger c = BigInteger.Parse(input2);
            string input3 = Console.ReadLine();
            int n = int.Parse(input3);

            BigInteger d = 0;
            
            if (n == 1)
                Console.WriteLine(a);
            else if (n == 2)
                Console.WriteLine(b);
            else if (n == 3)
                Console.WriteLine(c);
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    BigInteger next = a + b + c;
                    d = next;

                    a = b;
                    b = c;
                    c = next;

                    if (i == n)
                    {
                        Console.WriteLine(next);
                    }

                }
            }
        }
    }
}
