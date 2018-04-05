using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Frame
    {
        private string type;
        private string colour;
        private string size;
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

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }

        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
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
