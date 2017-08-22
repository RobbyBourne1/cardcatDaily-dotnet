using System;

namespace cardcatDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var library = new Library();

            var book = new Book 
            {
                BookName = "Green Eggs and Ham",
                Author = "Dr Suess",
                DateCheckedOut = DateTime.Now,
                IsCheckedOut = true
            };

            library.Catalog.Add(book);

            Console.WriteLine(book.BookName);
        }
    }
}
