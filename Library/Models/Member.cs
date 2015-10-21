using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public string MemberId { get; set; }
        [Required]
        public int Pnumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Loan loan { get; set; }

        public Member()
        {
            this.MemberId = generateNewId();

        }

        public Member(int pNummer, string firstName, string lastName, Loan _loan)
        {
            this.MemberId = generateNewId();
            this.Pnumber = pNummer;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.loan = _loan;
        }

        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
