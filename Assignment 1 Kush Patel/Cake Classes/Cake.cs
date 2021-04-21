using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Classes
{
    public class Cake {

        private String flavour;
        private int layers;


        public Cake() {
            Flavour = "No Flavour";
            Layers = 0;
        }

        public Cake(String f, int l) {
            Flavour = f;
            Layers = l;
        }



        public String Flavour {
            get { return flavour; }
            set { flavour = value; }
        }


        public int Layers {
            get { return layers; }
            set { layers = value; }
        }


        public override string ToString()
        {
            return "I am " + flavour + " Cake that has " + layers + " Layers";

        }

        public double calculateCakeCost(int l) {
            return ((20 + (l*3)) * 1.13);
        }

    }
}
