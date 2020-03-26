using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdealWeightCalculator
{
    public class DataAccessLayer
    {
        public WeightContext WeightContext { get; }
        public DataAccessLayer(WeightContext weightContext)
        {
            WeightContext = weightContext;
        }

        public void AddUser(User user)
        {
            WeightContext.Users.Add(user);
            WeightContext.SaveChanges();
        }

        public User GetUser(string name)
        {
            return WeightContext.Users.SingleOrDefault(u => u.Name == name);
        }
    }
}
