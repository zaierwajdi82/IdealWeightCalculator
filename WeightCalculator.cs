using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeightCalculator
{
    public class WeightCalculator
    {
        public double Height { get; set; }
        public char Sex { get; set; }
        public IDataRepository Repository { get; }

        public WeightCalculator(IDataRepository repository)
        {
            Repository = repository;
        }

        public WeightCalculator()
        {

        }
        public double GetIdealBodyWeight()
        {
            switch (Sex)
            { 
                case 'm':
                    return (Height-100)-((Height-150)/4);
                case 'w':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    throw new ArgumentException("The sex argument is not valid");
            }
        }

        public List<double> GetIdealBodyWeightFromDataSource()
        {
            List<double> results = new List<double>();

            IEnumerable<WeightCalculator> weights = Repository.GetWeight();

            foreach (var weight in weights)
            {
                results.Add(weight.GetIdealBodyWeight());
            }

            return results;
        }

        public bool Validate()
        {
            return Sex=='m'|| Sex == 'w';
        }
    }
}
