using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Loan item)
        {
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public void Edit(Loan item)
        {
        }

        public Loan Find(string id)
        {
            foreach (var loan in _context.Loans.ToList())
            {
                if (loan.LoanId == id)
                {
                    return loan;
                }
            }

            throw new Exception();
        }

        public void Remove(Loan item)
        {
        }
    }
}
