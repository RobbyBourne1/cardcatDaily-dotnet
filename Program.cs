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
                IsCheckedOut = false,
            };

            library.Catalog.Add(book);
            var titleSearch = library.SearchByBookName("Green Eggs and Ham");
            foreach (var item in titleSearch)
            {
                Console.WriteLine(item.BookName);
            }
            var authorSearch = library.SearchByBookAuthor("Dr Suess");
            foreach (var item in authorSearch)
            {
                Console.WriteLine(item.Author);
            }
            library.CheckOut("Green Eggs and Ham", "Dr Suess");

            library.SearchForOverdue("Green Eggs and Ham");
        }
    }
}
