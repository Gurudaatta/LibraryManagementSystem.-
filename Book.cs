using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void IssueBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Book '{Title}' issued successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is already issued.");
            }
        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"Book '{Title}' returned successfully.");
        }
    }
}