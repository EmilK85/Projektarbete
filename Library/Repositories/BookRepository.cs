using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookRepository<T, Tid>: IRepository<T, Tid>
    {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(T item)
        {
        }

        public IEnumerable<T> All()
        {
            return (IEnumerable<T>)_context.Books.ToList();
        }

        public void Edit(T item)
        {
        }

        public T Find(Tid id)
        {
            foreach(var book in _context.Books.ToList())
            {
                if(book.BookId == id.ToString())
                {
                    return (T)Convert.ChangeType(book, typeof(T));
                }
            }

            throw new Exception();
        }

        public void Remove(T item)
        {
        }
    }
}