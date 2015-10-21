using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class LoanService<T,Tid> : IService
    {
        LoanRepository<T, Tid> _loanRepository;

        public LoanService(RepositoryFactory<T,Tid> repoFactory)
        {
            _loanRepository = repoFactory.G
        }

        public event EventHandler Updated;
    }
}
