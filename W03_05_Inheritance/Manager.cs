using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_05_Inheritance
{
    public sealed class Manager:Teacher
    {
        public void ManagerMethod()
        {
            EmployeeProtectedMethod();
            TeacherProtectedMethod();
        }
    }
}
