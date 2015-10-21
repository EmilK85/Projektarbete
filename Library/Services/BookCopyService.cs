using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookCopyService<T, Tid> : IService
    {
        BookCopyRepository<T, Tid> _bookCopyRepository;

        public BookCopyService(RepositoryFactory<T, Tid> repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        public event EventHandler Updated;
    }
}
