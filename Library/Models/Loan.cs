using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {
        [Key]
        public string LoanId { get; set; }
        [Required]
        public string TimeOfLoan { get; set; }
        public string DueDate { get; set; }
        public string TimeOfRetrun { get; set; }
        public Book book { get; set; }
        public Member member { get; set; }

        public Loan()
        {
            this.LoanId = generateNewId();
        }

        public Loan(string timeOfLoan, string dueDate, Book _book, Member _member)
        {
            this.LoanId = generateNewId();
            this.TimeOfLoan = timeOfLoan;
            this.DueDate = dueDate;
            this.book = _book;
            this.member = _member;
            this.TimeOfRetrun = "";
        }

        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public override string ToString()
        {
            string name = this.member.FirstName + " " + this.member.LastName;
            return String.Format("[{0}] -- {1} -- {2} -- {3} -- {4} -- {5}", 
                this.LoanId, this.TimeOfLoan, this.DueDate,
                this.TimeOfRetrun, this.book.Title, name);
        }
    }
}
