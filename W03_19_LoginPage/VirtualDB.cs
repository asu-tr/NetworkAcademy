using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_19_LoginPage
{
    public class VirtualDB
    {
        public static List<User> users = new List<User>();

        static VirtualDB()
        {
            users.Add(new User() { ID = 1, Username = "admin", Password = "pwd" });
            users.Add(new User() { ID = 2, Username = "newuser", Password = "123456" });
        }
    }

}
