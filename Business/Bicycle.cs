using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Bicycle
    {
        private Frame frame;
        private FinishingSet finishingSet;
        private GroupSet groupSet;
        private Wheels wheels;
        private double cost;
        private int duration;

        public Frame Frame
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
            }
        }

        public FinishingSet FinishingSet
        {
            get
            {
                return finishingSet;
            }
            set
            {
                finishingSet = value;
            }
        }

        public GroupSet GroupSet
        {
            get
            {
                return groupSet;
            }
            set
            {
                groupSet = value;
            }
        }

        public Wheels Wheels
        {
            get
            {
                return wheels;
            }
            set
            {
                wheels = value;
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

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        public double calculateFinalCost(Frame frame, GroupSet gs, FinishingSet fs, Wheels wheels)
        {
            return 100.0 + frame.Cost + gs.Cost + fs.Cost + wheels.Cost;
        }
    }
}
