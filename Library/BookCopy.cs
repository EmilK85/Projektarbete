using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookCopy
    {
        public string BookCopyId { get; set; }
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
