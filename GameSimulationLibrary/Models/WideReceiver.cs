using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Models
{
    class WideReceiver : Player
    {
        public int Catching { get; set; }

        public WideReceiver(
            string firstName,
            string lastName
        )
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
