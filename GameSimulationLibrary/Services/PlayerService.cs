using GameSimulationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Services
{
    public abstract class PlayerService
    {
        private Player _player;

        public abstract void DetermineOverall();

        public int ProgressPlayerSkill(int skillValue, int potential, int overall)
        {
            {
                var rand = new Random();
                //var improveRate = rand.Next(0, _quarterback.Potential - _quarterback.Overall);

                //Weird attempt at a weighted random algorithm
                /*
                    weighted to favor low numbers, basically every iteration the number can be larger
                    but if it is the range it will "fall out" and be the increase rate
                    probably not very effiecent
                */
                int improveRate = 0;
                for (int i = 0; i <= 5; i++)
                {
                    improveRate = rand.Next(0, (potential - overall));
                    Console.WriteLine("i: " + i.ToString() + " val: " + improveRate.ToString());
                    if (improveRate <= 5 + i)
                    {
                        break;
                    }
                }

                return skillValue + improveRate;

            }
        }

        public int DetemineGeneralStatOverall()
        {
            return (_player.Awareness +
                    _player.Intelligence +
                    _player.Speed +
                    _player.Strength);
        }
    }
}
