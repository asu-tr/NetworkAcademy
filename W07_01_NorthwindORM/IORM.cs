using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W07_01_NorthwindORM
{
    interface IORM<T>
    {
        DataTable List_();
        bool Add_(T entity);
        bool Update_(T entity);
        bool Delete_(int id);
    }
}
