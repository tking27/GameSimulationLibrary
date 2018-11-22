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
            _quarterback.Overall = ((_quarterback.ThrowingAccuracy * 4) +
                                   (_quarterback.ThrowingPower * 4) +
                                   (_quarterback.Intelligence * 2) +
                                   (_quarterback.Awareness * 2) +
                                   (_quarterback.Speed * 2) +
                                   (_quarterback.Strength)) / 13;
        } 
        
        //TODO make all positions into classes
        public int ShortPassRoll()
        {
            var maxRoll = ((_quarterback.ThrowingAccuracy * 2) +
                          (_quarterback.ThrowingPower) +
                          (_quarterback.Intelligence) +
                          (_quarterback.Awareness)) / 5;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }

        public int LongPassRoll()
        {
            var maxRoll = ((_quarterback.ThrowingPower * 3) +
                          (_quarterback.ThrowingAccuracy * 2) +
                          (_quarterback.Intelligence) +
                          (_quarterback.Awareness)) / 7;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }

    }
}
