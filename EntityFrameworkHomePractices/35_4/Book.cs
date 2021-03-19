using System;
using System.Collections.Generic;
using System.Text;

namespace _35_4
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public User User { get; set; }
    }
}
