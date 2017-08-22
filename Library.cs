using System;
using System.Collections.Generic;
using System.Linq;

namespace cardcatDaily_dotnet
{
    class Library
    {
         public string Name { get; set; }
         public string Address { get; set; }
        
        public List<Book> Catalog = new List<Book>();

        public IEnumerable<Book> SearchByBookName(string name)
        {
            var search = Catalog.Where(w => w.BookName.Contains(name.ToLower()));
            return search;
        }

        public IEnumerable<Book> SearchByBookAuthor(string name)
        {
            var search = Catalog.Where(w => w.Author.Contains(name.ToLower()));
            return search;
        }
        public IEnumerable<Book> SearchForOverdue(DateTime datePublished)
        {
            var search = Catalog.Where(w => w.DateCheckedOut >= DateTime.Now);
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
                Console.WriteLine("The Book Is already Checked In");
            }
            else
            {
                Console.WriteLine("You are Checking in the Book");
                search.IsCheckedOut = false; 
            }
        }
    }
}