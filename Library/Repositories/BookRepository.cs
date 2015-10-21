using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository
    {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Book item)
        {
        }

        public IEnumerable<Book> All()
        {
            return _context.Books.ToList();
        }

        public void Edit(Book item)
        {
        }

        public Book Find(string id)
        {
            foreach(var book in _context.Books.ToList())
            {
                if(book.BookId == id)
                {
                    return book;
                }
            }

            throw new Exception();
        }

        public void Remove(Book item)
        {
        }
    }
}