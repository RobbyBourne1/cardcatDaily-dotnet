using System;
using System.Collections.Generic;
using System.Linq;

namespace cardcatDaily_dotnet
{
    class Library : Book
    {
         public string Name { get; set; }
         public string Address { get; set; }
        
        public List<Book> Catalog = new List<Book>();

        public string SearchByBookName(string name)
        {
            var search = Catalog.Where(w => w.BookName == name).ToString();
            return search;
        }

        public string SearchByBookAuthor(string name)
        {
            var search = Catalog.Where(w => w.Author == name).ToString();
            return search;
        }
        public string SearchForOverdue(DateTime datePublished)
        {
            var search = Catalog.Where(w => w.DateCheckedOut >= DateTime.Now).ToString();
            return search;
        }

        public void CheckOut(string bookName, string memberName)
        {
            var search = Catalog.FirstOrDefault(w => w.BookName == bookName);
            if (search.IsCheckedOut == true)
            {
                Console.WriteLine("This book is checked out");
            }
            else
            {
                Console.WriteLine("This Book is Available");
            }
        }
        public void CheckIn(string bookName, string memberName)
        {
            var search = Catalog.FirstOrDefault(w => w.BookName == bookName);
            if (search.IsCheckedOut == false)
            {
                Console.WriteLine("You checked the book in");
            }
            else
            {
                Console.WriteLine("This Book is Available");
                search.IsCheckedOut = false; 
            }
        }
    }
}