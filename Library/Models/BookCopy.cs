using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public string BookCopyId { get; set; }
        [Required]
        public Book book { get; set; }

        public BookCopy()
        {
            this.BookCopyId = generateNewId();
        }

        public BookCopy(Book _book)
        {
            this.BookCopyId = generateNewId();
            this.book = _book;
        }

        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
