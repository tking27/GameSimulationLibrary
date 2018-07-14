using GameSimulationLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Models
{
    class Player : IPlayer<Player>
    {
        public string FirstName;
        public string LastName;
        public int Overall;

        public void DetermineOverall(List<int> intList)
        {
            intList.Sort();
            int total = 0, count = 0;

            foreach(var num in intList)
            {
                total = (num * (intList.Count - count++));
            }

            Overall = (total / intList.Count);
        }
    }
}
