using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string BookId { get; set; }
        public long IsbnNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author author { get; set; }

        public Book()
        {
            this.BookId = generateNewId();
        }

        public Book(long isbnNumber, string title, string description, Author _author)
        {
            this.BookId = generateNewId();
            this.IsbnNumber = isbnNumber;
            this.Title = title;
            this.Description = description;
            this.author = _author;
        }

        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }

        //    public override string ToString()
        //    {
        //        return String.Format("[{0}] -- {1}", this.BookId, this.Title, this.IsbnNumber, 
        //            this.Description, this.author);
        //    }
    }
}
