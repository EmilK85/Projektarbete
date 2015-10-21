using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository<T, Tid> : IRepository<T, Tid>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(T item)
        {
        }

        public IEnumerable<T> All()
        {
            return (IEnumerable<T>)_context.BookCopies.ToList();
        }

        public void Edit(T item)
        {
        }

        public T Find(Tid id)
        {
            foreach (var bookCopy in _context.BookCopies.ToList())
            {
                if (bookCopy.BookCopyId == id.ToString())
                {
                    return (T)Convert.ChangeType(bookCopy, typeof(T));
                }
            }

            throw new Exception();
        }

        public void Remove(T item)
        {
        }
    }
}
