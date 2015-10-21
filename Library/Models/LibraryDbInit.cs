using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            string description = @"The story of Edmund Dantes, self-styled Count of Monte Cristo, is told with consummate skill. 
                The victim of a miscarriage of justice, Dantes is fired by a desire for retribution and empowered
                by a stroke of providence.In his campaign of vengeance, he becomes an anonymous agent of fate.
                The sensational narrative of intrigue, betrayal, escape, and triumphant revenge moves at a cracking
                pace.Dumas novel presents a powerful conflict between good and evil embodied in an epic saga of rich
                diversity that is complicated by the heros ultimate discomfort with the hubristic implication of his
                own actions.";

            List<Book> bList = new List<Book>();

            Author AlexandreDumas = new Author("Alexandre Dumas", bList);

            Book monteCristo = new Book() {
                Title = "The Count of Monte Cristo",
                IsbnNumber = 9781435132115,
                nrOfCopies = 1,
                Description = description,
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
