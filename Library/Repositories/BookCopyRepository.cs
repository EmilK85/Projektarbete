using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(BookCopy item)
        {
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

        public void Edit(BookCopy item)
        {
        }

        public BookCopy Find(string id)
        {
            foreach (var bookCopy in _context.BookCopies.ToList())
            {
                if (bookCopy.BookCopyId == id)
                {
                    return bookCopy;
                }
            }

            throw new Exception();
        }

        public void Remove(BookCopy item)
        {
        }
    }
}
