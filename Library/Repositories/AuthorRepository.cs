using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository<T, Tid> : IRepository<T, Tid>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(T item)
        {
        }

        public IEnumerable<T> All()
        {
            return (IEnumerable<T>)_context.Authors.ToList();
        }

        public void Edit(T item)
        {
        }

        public T Find(Tid id)
        {
            foreach (var author in _context.Authors.ToList())
            {
                if (author.AuthorId == id.ToString())
                {
                    return (T)Convert.ChangeType(author, typeof(T));
                }
            }

            throw new Exception();
        }

        public void Remove(T item)
        { 
        }
    }
}
