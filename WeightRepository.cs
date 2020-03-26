using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeightCalculator
{
    class WeightRepository:IDataRepository
    {
        IEnumerable<WeightCalculator> weights;

        public WeightRepository()
        {
            weights = new List<WeightCalculator>()
            {
                new WeightCalculator {Height=175,Sex='w'},
                new WeightCalculator {Height=167,Sex='m'},
                new WeightCalculator {Height=182,Sex='m'}
            };
        }

        public IEnumerable<WeightCalculator> GetWeight()
        {
            return weights;
        }
    }
}
