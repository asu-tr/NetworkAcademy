using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04_02_Automation
{
    public class Pizza
    {
        public string Name;
        public Size Size;
        public double Price;
        public Crust Crust;
        public List<string> Ingredients;

        public override string ToString()
        {
            return Name + " - " + Price;
        }
    }
}
