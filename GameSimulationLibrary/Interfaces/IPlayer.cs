using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Interfaces
{
    interface IPlayer<T>
    {
        void DetermineOverall(List<int> intList);
    }
}
