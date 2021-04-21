using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Classes
{
    public class CharacterCake : Cake
    {
        private string cakeType;
        private int cakeCost;

        public string CakeType
        {
            get { return cakeType; }
            set { cakeType = value; }
        }


        public int CakeCost
        {
            get { return cakeCost; }
            set { cakeCost = value; }
        }


        public CharacterCake(string f, int l, string ct, int cc) : base(f, l)
        {
            CakeType = ct;
            CakeCost = cc;
        }

        public double calculateCakeCost(int cc, int l)
        {
            return ((cc + (l * 3)) * 1.13);
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Of Character: " + CakeType;
        }

    }
}
