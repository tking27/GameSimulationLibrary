using GameSimulationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Services
{
    public class QuarterbackService : PlayerService
    {
        private Quarterback _quarterback;

        public QuarterbackService(
            Quarterback quarterback
        )
        {
            _quarterback = quarterback;
        }

        public override void DetermineOverall()
        {
            //Definitley open to change

            _quarterback.Overall = (((_quarterback.ThrowingAccuracy +
                                    _quarterback.ThrowingPower) * 8) +
                                    DetemineGeneralStatOverall()) / 12;
        }       
    }
}
