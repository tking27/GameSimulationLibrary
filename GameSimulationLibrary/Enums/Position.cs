using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulationLibrary.Enums
{
    class Position
    {
        private string _value { get; set; }

        public Position(string value)
        {
            _value = value;
        }

        public string GetValue()
        {
            return _value;
        }

        public static Position Quarterback = new Position("Quarterback");
        public static Position RunningBack = new Position("RunningBack");
        public static Position WideReceiver = new Position("WideReceiver");
        public static Position TightEnd = new Position("TightEnd");
        public static Position OffensiveLine = new Position("OffensiveLine");
        public static Position DefensiveLine = new Position("DefensiveLine");
        public static Position LineBacker = new Position("LineBacker");
        public static Position CornerBack = new Position("CornerBack");
        public static Position Safety = new Position("Safety");

    }
}
