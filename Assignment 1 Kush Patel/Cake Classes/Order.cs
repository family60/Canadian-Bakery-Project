using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Classes
{
    public class Order {

        private string totalCost;

        public Order() {
            totalCost = "n/a";
        }

        public Order(String tc) {
            totalCost = tc;
        }


        public String TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
    }
}
