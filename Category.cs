using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_1
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
