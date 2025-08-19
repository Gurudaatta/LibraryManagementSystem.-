using System;

namespace LibraryManagementSystem
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Transaction(int transactionId, Member member, Book book)
        {
            TransactionId = transactionId;
            Member = member;
            Book = book;
            IssueDate = DateTime.Now;
            ReturnDate = null;
        }

        public void ReturnBook()
        {
            if (Book.IsAvailable == false)
            {
                Book.ReturnBook();
                ReturnDate = DateTime.Now;
                Console.WriteLine($"Book '{Book.Title}' returned by {Member.Name} on {ReturnDate}");
            }
            else
            {
                Console.WriteLine($"Book '{Book.Title}' is already available.");
            }
        }

        public void DisplayTransaction()
        {
            Console.WriteLine($"Transaction ID: {TransactionId}");
            Console.WriteLine($"Member: {Member.Name}");
            Console.WriteLine($"Book: {Book.Title}");
            Console.WriteLine($"Issued On: {IssueDate}");
            Console.WriteLine($"Returned On: {(ReturnDate.HasValue ? ReturnDate.ToString() : "Not yet returned")}");
        }
    }
}