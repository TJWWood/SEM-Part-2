using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Customer
    {
        private string first_name;
        private string last_name;
        private string address;
        private string email;

        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }

        public string LastName
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
