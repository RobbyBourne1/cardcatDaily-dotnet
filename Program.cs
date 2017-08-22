using System;

namespace cardcatDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

            var library = new Library();

            var book = new Book 
            {
                BookName = "Green Eggs and Ham",
                Author = "Dr Suess",
                DateCheckedOut = DateTime.Now,
                IsCheckedOut = true,
            };

            library.Catalog.Add(book);
            var Title = library.SearchByBookName("Green Eggs and Ham");
            Console.WriteLine(Title);
            Console.WriteLine(book.BookName);
        }
    }
}
