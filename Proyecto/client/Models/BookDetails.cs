using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace WebClient.Models
{
    public class BookDetails
    {
        public Book book { get; set; }
        public Review review { get; set; }

        public Popular popular { get; set; }

        private List<Review> _bookReviews = new List<Review>();

        public List<Review> bookReviews
        {
            set { _bookReviews = value;}
            get { return _bookReviews; }
        }

        private List<Popular> _bookPopular = new List<Popular>();

        public List<Popular> bookPopular
        {
            set { _bookPopular = value; }
            get { return _bookPopular; }
        }

        private List<Book> _book = new List<Book>();

        public List<Book> BookList
        {
            set { _book = value; }
            get { return _book; }
        }
    }
}
