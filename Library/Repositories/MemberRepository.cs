using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Member item)
        {
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

        public void Edit(Member item)
        {
        }

        public Member Find(string id)
        {
            foreach (var member in _context.Members.ToList())
            {
                if (member.MemberId == id)
                {
                    return member;
                }
            }

            throw new Exception();
        }

        public void Remove(Member item)
        {
        }
    }
}
