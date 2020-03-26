using System;

namespace IdealWeightCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightCalculator wc = new WeightCalculator
            {
                Height = 180,
                Sex = 'm'
            };

            double weight = wc.GetIdealBodyWeight();

            Console.WriteLine($"the idealbody weight is: {weight} ");

            Console.ReadKey();
        }
    }
}
