using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    class MemberRepository<T, Tid> : IRepository<T, Tid>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(T item)
        {
        }

        public IEnumerable<T> All()
        {
            return (IEnumerable<T>)_context.Members.ToList();
        }

        public void Edit(T item)
        {
        }

        public T Find(Tid id)
        {
            foreach (var member in _context.Members.ToList())
            {
                if (member.MemberId == id.ToString())
                {
                    return (T)Convert.ChangeType(member, typeof(T));
                }
            }

            throw new Exception();
        }

        public void Remove(T item)
        {
        }
    }
}
