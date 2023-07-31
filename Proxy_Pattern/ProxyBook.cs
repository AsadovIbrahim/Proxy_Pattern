using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class ProxyBook:IBook
    {
        private string title;
        private string author;
        private RealBook realBook;
        private static Dictionary<string, RealBook> bookCache = new Dictionary<string, RealBook>();

        public ProxyBook(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public void Display()
        {
            if (realBook == null)
            {
                if (bookCache.ContainsKey(title))
                {
                    realBook = bookCache[title];
                }
                else
                {
                    realBook = new RealBook(title, author);
                    bookCache.Add(title, realBook);
                }
            }
            realBook.Display();
        }
    }
}
