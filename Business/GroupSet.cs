using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GroupSet
    {
        private Gears gears;
        private Breaks breaks;
        private double cost;

        public Gears Gears
        {
            get
            {
                return gears;
            }
            set
            {
                gears = value;
            }
        }

        public Breaks Breaks
        {
            get
            {
                return breaks;
            }
            set
            {
                breaks = value;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public double calculateGroupSet(Gears gears, Breaks breaks)
        {
            double output = gears.Cost + breaks.Cost;
            return output;
        }
    }
}
