using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookService<T,Tid>: IService
    {
        BookRepository<T,Tid> _bookRepository;

        public BookService(RepositoryFactory<T,Tid> repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public event EventHandler Updated;

        public IEnumerable<Book> All()
        {
            return (IEnumerable<Book>)_bookRepository.All();
        } 
    }
}
