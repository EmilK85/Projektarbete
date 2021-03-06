﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public string BookId { get; set; }
        [Required]
        public string Title { get; set; }

        public long IsbnNumber { get; set; }
        public int nrOfCopies { get; set; }
        public string Description { get; set; }
        public Author author { get; set; }

        public Book()
        {
            this.BookId = generateNewId();
        }

        public Book(long isbnNumber, string title, int copies, string description, Author _author)
        {
            this.BookId = generateNewId();
            this.IsbnNumber = isbnNumber;
            this.Title = title;
            this.nrOfCopies = copies;
            this.Description = description;
            this.author = _author;
        }

        private string generateNewId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1} -- {2} -- {3} -- {4} -- {5}", 
                this.BookId, this.Title, this.nrOfCopies, this.IsbnNumber,
                this.Description, this.author.Name);
        }
    }
}