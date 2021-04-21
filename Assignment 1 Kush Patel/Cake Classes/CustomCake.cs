using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Classes
{
    public class CustomCake : Cake {

        private String occasion, design;
        private int size;


        public string Occasion {
            get{ return occasion; }
            set { occasion = value; }
        }

        public string Design {
            get { return design; }
            set { design = value; }
        }

        public int Size {
            get { return size; }
            set { size = value; }
        }

        public CustomCake(string f, int l, string o, string d, int s) : base(f, l){
            Occasion = o;
            Design = d;
            Size = s;
        }


        public double calculateCakeCost(int l, int d, int s) {
            return (((20 + (l*3)) + d + s) * 1.13);
        }

        public override string ToString()
        {
            return base.ToString() + "\nfor Occasion: " + Occasion + "\nwith " + Design + " Design " + "\nof Size: " + Size + "\"";
        }

    }
}
