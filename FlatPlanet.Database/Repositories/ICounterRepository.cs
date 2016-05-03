using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.Database.Repositories
{
    public interface ICounterRepository
    {
        int IncreaseCount();
        int GetCount();
    }
}
