using GameSimulationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Services
{
    class WidereceiverService : PlayerService
    {
        private WideReceiver _widereceiver;

        public WidereceiverService(
            WideReceiver widereceiver
        )
        {
            _widereceiver = widereceiver;
        }

        public override void DetermineOverall()
        {
            _widereceiver.Overall = ((_widereceiver.Catching * 6) +
                                    (_widereceiver.Speed * 4) +
                                    (_widereceiver.Awareness) +
                                    (_widereceiver.Intelligence)) / 12;
        }

        public int ShortPassRoll()
        {
            var maxRoll = ((_widereceiver.Catching * 6) +
                          (_widereceiver.Speed * 2) +
                          (_widereceiver.Awareness)) / 9;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }

        public int LongPassRoll()
        {
            var maxRoll = ((_widereceiver.Catching * 6) +
                          (_widereceiver.Speed * 6) +
                          (_widereceiver.Awareness)) / 13;

            var rand = new Random();

            return rand.Next(0, maxRoll);
        }
    }
}
