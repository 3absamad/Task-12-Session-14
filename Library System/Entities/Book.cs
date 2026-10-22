using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System.Entities
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
