using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Saddle
    {
        private string type;
        private double cost;

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
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
    }
}
