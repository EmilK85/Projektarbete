using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            List<Book> bookList= new List<Book>();
            Author AlexandreDumas = new Author("Alexandre Dumas", bookList);

            Book monteCristo = new Book() {
                Title = "The Count of Monte Cristo",
                IsbnNumber = 9781853267338,
                Description = "",
                author = AlexandreDumas
            };

            AlexandreDumas.BookList.Add(monteCristo);

            // Add the book to the DbSet of books.
            context.Books.Add(monteCristo);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
