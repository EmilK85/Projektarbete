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
        }
        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
