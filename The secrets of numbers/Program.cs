using System;
using System.Numerics;

namespace The_secrets_of_numbers
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            
            BigInteger number = BigInteger.Parse(n);
            if (number < 0)
            {
                number = -number;
            }

            BigInteger multiplyed = 1;
            BigInteger position = 1;
            BigInteger specialSum = 0;


            for (int j = 0; j < n.Length; j++)
            {
                BigInteger nextDigit = (number / multiplyed) % 10;
                multiplyed *= 10;
                if (position % 2 != 0)
                {
                    specialSum += nextDigit * (position * position);
                    position++;
                }
                else
                {
                    specialSum += (nextDigit * nextDigit) * position;
                    position++;
                }
            }
            Console.WriteLine(specialSum);
            BigInteger R = specialSum % 26;
            BigInteger letter = R + 1;
            BigInteger lastDigitSpecialSum = specialSum % 10;

            if (lastDigitSpecialSum == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                for (int i = 1; i <= lastDigitSpecialSum; i++)
                {
                    if (letter == 1)
                    {
                        Console.Write("A");
                    }
                    if (letter == 2)
                    {
                        Console.Write("B");
                    }
                    if (letter == 3)
                    {
                        Console.Write("C");
                    }
                    if (letter == 4)
                    {
                        Console.Write("D");
                    }
                    if (letter == 5)
                    {
                        Console.Write("E");
                    }
                    if (letter == 6)
                    {
                        Console.Write("F");
                    }
                    if (letter == 7)
                    {
                        Console.Write("G");
                    }
                    if (letter == 8)
                    {
                        Console.Write("H");
                    }
                    if (letter == 9)
                    {
                        Console.Write("I");
                    }
                    if (letter == 10)
                    {
                        Console.Write("J");
                    }
                    if (letter == 11)
                    {
                        Console.Write("K");
                    }
                    if (letter == 12)
                    {
                        Console.Write("L");
                    }
                    if (letter == 13)
                    {
                        Console.Write("M");
                    }
                    if (letter == 14)
                    {
                        Console.Write("N");
                    }
                    if (letter == 15)
                    {
                        Console.Write("O");
                    }
                    if (letter == 16)
                    {
                        Console.Write("P");
                    }
                    if (letter == 17)
                    {
                        Console.Write("Q");
                    }
                    if (letter == 18)
                    {
                        Console.Write("R");
                    }
                    if (letter == 19)
                    {
                        Console.Write("S");
                    }
                    if (letter == 20)
                    {
                        Console.Write("T");
                    }
                    if (letter == 21)
                    {
                        Console.Write("U");
                    }
                    if (letter == 22)
                    {
                        Console.Write("V");
                    }
                    if (letter == 23)
                    {
                        Console.Write("W");
                    }
                    if (letter == 24)
                    {
                        Console.Write("X");
                    }
                    if (letter == 25)
                    {
                        Console.Write("Y");
                    }
                    if (letter == 26)
                    {
                        Console.Write("Z");
                        letter = 0;
                    }
                    letter++;
                }
            }
            Console.WriteLine();
        }
    }
}