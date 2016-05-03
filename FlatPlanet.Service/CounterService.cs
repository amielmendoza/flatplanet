using FlatPlanet.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.Service
{
    public class CounterService : ICounterService
    {
        private ICounterRepository _counterRepository;
        public CounterService()
        {
            _counterRepository = new CounterRepository();
        }
        public int IncreaseCount()
        {
            return _counterRepository.IncreaseCount();
        }
    }
}
