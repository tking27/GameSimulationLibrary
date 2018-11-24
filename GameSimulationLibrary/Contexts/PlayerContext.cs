using GameSimulationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Contexts
{
    class PlayerContext : DbContext
    {
        public DbSet<Quarterback> Quarterbacks { get; set; }
        public DbSet<Runningback> Runningbacks { get; set; }
        public DbSet<WideReceiver> Widereceivers { get; set; }
    }
}
