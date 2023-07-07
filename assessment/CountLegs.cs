using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class CountLegs
    {
        private int Chickens;
        private int cows;
        private int pigs;
       

        

        public int Chickens1 { get => Chickens; set => Chickens = value; }
        public int Cows { get => cows; set => cows = value; }
        public int Pigs { get => pigs; set => pigs = value; }

        public  CountLegs(int chickens, int cows, int pigs)
        {
            this.Chickens1 = chickens;
            this.Cows = cows;
            this.Pigs = pigs;

        }

        public int Animals(int x, int y, int z)
        {
            int count;
            count = x * 2 + y * 4 + z * 4;

            return count;
        }
    }
}

