using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System.Entities
{
    internal class Loan
    {
        public int BookId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Borrower Borrower { get; set; }
    }
}
