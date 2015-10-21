using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Author item)
        {
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        public void Edit(Author item)
        {
        }

        public Author Find(string id)
        {
            foreach (var author in _context.Authors.ToList())
            {
                if (author.AuthorId == id)
                {
                    return author;
                }
            }

            throw new Exception();
        }

        public void Remove(Author item)
        { 
        }
    }
}
