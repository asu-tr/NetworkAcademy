using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_10_Enum_Example
{
    public class VirtualDB
    {
        ArrayList db = new ArrayList();

        public dbReturn AddBook(Book book)
        {
            db.Add(book);
            return dbReturn.Successfull;
        }
    }
}