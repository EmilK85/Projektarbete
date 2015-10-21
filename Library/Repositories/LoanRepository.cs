using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository<T, Tid> : IRepository<T, Tid>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(T item)
        {
        }

        public IEnumerable<T> All()
        {
            return (IEnumerable<T>)_context.Loans.ToList();
        }

        public void Edit(T item)
        {
        }

        public T Find(Tid id)
        {
            foreach (var loan in _context.Loans.ToList())
            {
                if (loan.LoanId == id.ToString())
                {
                    return (T)Convert.ChangeType(loan, typeof(T));
                }
            }

            throw new Exception();
        }

        public void Remove(T item)
        {
        }
    }
}
