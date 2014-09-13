using System;

namespace Peace_of_Cakes
{
    class Program
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());

            decimal total = ((a*d) + (b*c)) / (b*d);
            
            if (total >= 1)
            {
                Console.WriteLine(Math.Floor(total));
            }
            else
            {
                Console.WriteLine("{0:F22}", total);
            }

            decimal nominator = (a * d)+(b * c);
            decimal denominator = (b * d);

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
