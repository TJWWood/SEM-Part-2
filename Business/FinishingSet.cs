using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class FinishingSet
    {
        private Handlebars handle_bars;
        private Saddle saddle;
        private double cost;

        public Handlebars HandleBars
        {
            get
            {
                return handle_bars;
            }
            set
            {
                handle_bars = value;
            }
        }

        public Saddle Saddle
        {
            get
            {
                return saddle;
            }
            set
            {
                saddle = value;
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

        public double calculateFinishingSet(Handlebars handle, Saddle saddle)
        {
            double output = handle.Cost + saddle.Cost;
            cost = output;
            return output;
        }
    }
}
