using System;

namespace The_Horror
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int numbers = 0;
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    
                    int num = (int)Char.GetNumericValue(input[i]);
                    if (num == 0 || num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 7
                    || num == 8 || num == 9)
                    {
                        result += num;
                        numbers++;
                    }
                }
            }
            Console.WriteLine(numbers + " " + result);
            
        }
    }
}
