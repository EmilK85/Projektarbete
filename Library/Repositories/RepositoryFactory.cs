using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Repositories;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// This class handles instantiation of the repositories.
    /// </summary>
    public class RepositoryFactory<T,Tid>
    {
        /// <summary>
        /// Wrapper property to get a context instance.
        /// </summary>
        static LibraryContext context
        {
            get { return ContextSingleton.GetContext(); }
        }

        /// <summary>
        /// Retrieve a book repository instance.
        /// </summary>
        public BookRepository<T,Tid> GetBookRepository()
        {
            return new BookRepository<T,Tid>(context);
        }

        public LoanRepository<T, Tid> GetLoanRepository()
        {
            return new LoanRepository<T, Tid>(context);
        }

        // More repositories..
    }
}