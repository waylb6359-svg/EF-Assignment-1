using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_1
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
