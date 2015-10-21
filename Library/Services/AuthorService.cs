using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService<T,Tid> : IService
    {
        AuthorRepository<T, Tid> _loanRepository;

        public AuthorService(RepositoryFactory<T, Tid> repoFactory)
        {
            _loanRepository = repoFactory.GetAuthorRepository();
        }

        public event EventHandler Updated;
    }
}
