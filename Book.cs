using System;

namespace cardcatDaily_dotnet
{
    class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public bool IsCheckedOut { get; set; }
        public Member MyProperty { get; set; }

        public Book()
        {
        }
    }
}