using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.Database.Repositories
{
    public class CounterRepository : ICounterRepository
    {
        public int IncreaseCount()
        {
            using (var context = new FlatPlanetEntities())
            {
                var count = 0;
                var currentCount = context.Counters.FirstOrDefault();
                if (currentCount == null)
                {
                    var newCount = new Counter();
                    newCount.Count = 1;
                    context.Counters.Add(newCount);
                    count = newCount.Count;
                }
                else
                {
                    currentCount.Count = currentCount.Count + 1;
                    count = currentCount.Count;
                }

                context.SaveChanges();
                return count;
            }
        }


        public int GetCount()
        {
            using (var context = new FlatPlanetEntities())
            {
                var counter = context.Counters.FirstOrDefault();

                if (counter == null)
                    return 0;
                else
                    return counter.Count;
            }
        }
    }
}
