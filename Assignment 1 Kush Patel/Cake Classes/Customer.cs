using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Classes
{
    public class Customer {

        private String fname, lname;

        public Customer() {
            Fname = "No First Name";
            Lname = "No Last Name";
        }

        public Customer(String f, String l) {
            Fname = f;
            Lname = l;
        }

        public String Fname {
            get { return fname; }
            set { fname = value; }
        }

        public String Lname {
            get { return lname; }
            set { lname = value; }
        }

        public override string ToString()
        {
            return "First Name: " + fname + " Last Name: " + lname;
        }



    }
}
