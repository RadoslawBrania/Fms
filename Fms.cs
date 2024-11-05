using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Fms
    {
        public int enchant=0;
        public int[] chance= new int[9];
        public int[] cost = new int[9];
        public long price = 0;
        bool justburned = false;
        int bodzio = 350000;
        Random f = new();

        public Fms()
        {
            this.chance[0] = 95;
            this.chance[1] = 95;
            this.chance[2] = 95;
            this.chance[3] = 85;
            this.chance[4] = 75;
            this.chance[5] = 65;
            this.chance[6] = 55;
            this.chance[7] = 45;
            this.chance[8] = 35;
            this.cost[0] = 3000;
            this.cost[1] = 6000;
            this.cost[2] = 12000;
            this.cost[3] = 25000;
            this.cost[4] = 40000;
            this.cost[5] = 60000;
            this.cost[6] = 90000;
            this.cost[7] = 120000;
            this.cost[8] = 150000;
        }
        public void enhance()
        {

            this.price += this.cost[this.enchant];
            if (this.enchant >3 ) this.price += this.bodzio;
            if (this.f.Next(1, 100) < this.chance[this.enchant])
            {
                this.enchant += 1;
            }
            else if (this.enchant < 4) { this.enchant = 0; this.price += 2500000; }
            else if (this.enchant > 0) this.enchant -= 1;
      
        }
    }
}
