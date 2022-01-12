using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_10_Enum_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualDB db = new VirtualDB();

            Book book = new Book();
            book.ID = 1;
            book.Title = "The Adventures of Tom Sawyer";
            book.Author = "Mark Twain";

            dbReturn result = db.AddBook(book);

            if (result == dbReturn.Successfull)
            {
                Console.WriteLine("Added to db.");
            }
            else if (result == dbReturn.Error)
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
