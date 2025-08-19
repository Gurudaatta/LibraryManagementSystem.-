using System;

namespace LibraryManagementSystem
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Member(int memberId, string name, string email)
        {
            MemberId = memberId;
            Name = name;
            Email = email;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}