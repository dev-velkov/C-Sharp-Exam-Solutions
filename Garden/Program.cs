using System;

namespace Garden
{
    class Program
    {
        static void Main()
        {
            int tomato = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumber = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potato = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrot = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbage = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beans = int.Parse(Console.ReadLine());

            double cucumberPrice = 0.4 * cucumber;
            double tomatoPrice = 0.5 * tomato;
            double potatoPrice = 0.25 * potato;
            double carrotPrice = 0.6 * carrot;
            double cabbagePrice = 0.3 * cabbage;
            double beansPrice = 0.4 * beans;

            double priceSum = cucumberPrice + tomatoPrice + potatoPrice + cabbagePrice + carrotPrice + beansPrice;

            Console.WriteLine("Total costs: {0:F2}", priceSum);

            int totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            
            if (totalArea < 250)
            {
                Console.WriteLine("Beans area: {0}", 250-totalArea);
            }
            else if (totalArea == 250)
            {
                Console.WriteLine("No area for beans");
            }
            else if (totalArea > 250)
            {
                Console.WriteLine("Insufficient area");
            }

        }
    }
}
