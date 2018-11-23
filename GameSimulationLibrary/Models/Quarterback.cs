using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Models
{
    public class Quarterback : Player
    {
        public int ThrowingPower { get; set; }
        public int ThrowingAccuracy { get; set; }

        public Quarterback
        (
            string firstName,
            string lastName
        )
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
