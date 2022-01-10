using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_02_Static
{
    public static class Helper
    { // everything should be static here
        public static void SendEmail(string receiver)
        {
            Console.WriteLine($"The mail has sent to {receiver}");
        }

        static Helper()
        {

        }
    }
}
