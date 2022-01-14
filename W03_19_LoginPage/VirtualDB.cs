using System;
using System.Collections.Generic;

namespace W03_19_LoginPage
{
    public class VirtualDB
    {
        public static List<User> users = new List<User>();

        static VirtualDB()
        {
            users.Add(new User() { ID = 1, Username = "admin", Password = "pwd", FirstName = "Admin", LastName = "ADMIN" });
            users.Add(new User() { ID = 2, Username = "newuser", Password = "123456" });
        }
    }
}