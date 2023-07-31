using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class RealBook:IBook
    {
        public string title;
        public string author;

        public RealBook(string title, string author)
        {
            this.title = title;
            this.author = author;
            LoadFromDataBase();
        } 
        public void LoadFromDataBase()
        {
            Console.WriteLine($"Loading book '{title}' by {author} from the database...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Book '{title}' by {author} loaded successfully.");
        }
        public void Display()
        {
            Console.WriteLine($"Displaying book '{title}' by {author}.");
        }
    }
}
