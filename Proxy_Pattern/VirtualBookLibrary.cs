using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class VirtualBookLibrary
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book)
        {
            books.Add(book);
        }
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                book.Display();
            }
        }
    }
}
