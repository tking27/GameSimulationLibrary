using GameSimulationLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Models
{
    public class Player
    {
        // General Information
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Overall { get; set; }
        public int Potential { get; set; }

        //General Stats
        public int Speed { get; set; }
        public int Awareness { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
    }
}
