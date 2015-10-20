using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public string AuthorId { get; set; }
        public string Name { get; set; }
        public List<Book> BookList { get; set; }

        public Author()
        {
            this.AuthorId = generateNewId();
        }

        public Author(string name, List<Book> bookList)
        {
            this.AuthorId = generateNewId();
            this.Name = name;
            this.BookList = new List<Book>();
            this.BookList = bookList;

        }

        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
