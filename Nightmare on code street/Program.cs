using System;
using System.Linq;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        int OddNumbers = 0;

        for (int i = 1; i < input.Length; i += 2)
        {
            if (char.IsDigit(input[i]))
            {
                sum += input[i] - '0';
                OddNumbers++;
            }
        }

        Console.WriteLine("{0} {1}", OddNumbers, sum);
    }
}