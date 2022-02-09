using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_05_ReadRSS
{
    public class News
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Title + " - " + Description;
        }
    }
}
