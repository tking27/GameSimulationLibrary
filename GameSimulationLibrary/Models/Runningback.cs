using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Models
{
    class Runningback : Player
    {
        public int Carrying { get; set; }
        public int Catching { get; set; }

        public Runningback(
            string firstname,
            string lastname
        )
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
