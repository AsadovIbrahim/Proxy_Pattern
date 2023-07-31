namespace Proxy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VirtualBookLibrary library = new VirtualBookLibrary();

            library.AddBook(new ProxyBook("Book1", "Author1"));
            library.AddBook(new ProxyBook("Book2", "Author2"));
            library.AddBook(new ProxyBook("Book1", "Author1"));

            library.DisplayBooks();
        }
    }
}