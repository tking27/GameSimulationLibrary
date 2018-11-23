using GameSimulationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Services
{
    class RunningbackService : PlayerService
    {
        private Runningback _runningback;

        public RunningbackService(
            Runningback runningback
        )
        {
            _runningback = runningback;
        }

        public override void DetermineOverall()
        {
            _runningback.Overall = ((_runningback.Carrying * 6) +
                                    (_runningback.Catching * 4) +
                                    (_runningback.Speed * 4) +
                                    (_runningback.Strength * 4) +
                                    (_runningback.Intelligence) +
                                    (_runningback.Awareness)) / 20;
        }

        public int InsideRunRoll()
        {
            var maxRoll = ((_runningback.Carrying * 6) +
                          (_runningback.Strength * 4) +
                          (_runningback.Speed * 2) +
                          (_runningback.Awareness)) / 13;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }

        public int OutsideRunRoll()
        {
            var maxRoll = ((_runningback.Speed * 6) +
                          (_runningback.Carrying * 4) +
                          (_runningback.Strength * 2) +
                          (_runningback.Awareness)) / 13;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }

        public int ShortPassRoll()
        {
            var maxRoll = ((_runningback.Catching * 6) +
                          (_runningback.Speed * 4) +
                          (_runningback.Awareness)) / 11;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }


    }
}
