using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_09_Enum
{
    public enum race
    {
        German_Shepherd, Golden, Siberian_Husky, Dachshund
    }
    public class Animal
    {
        public string ID;
        public race Race;
        public string Name;
    }
}
