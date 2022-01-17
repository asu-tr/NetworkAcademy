using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04_02_Automation
{
    public class Order
    {
        public List<Pizza> Pizzas;
        public double Total;

        public override string ToString()
        {
            string ret = "";

            foreach (Pizza p in this.Pizzas)
            {
                ret += p.Name + " (" + p.Crust.Name + ", " + p.Size + ") - $" + p.Price;
                foreach (string ingr in p.Ingredients)
                {
                    ret += "\n- " + ingr;
                }
                ret += "\n\n";
            }
            ret += "\nTotal: $" + Total + "\n";

            return ret;
        }
    }
}