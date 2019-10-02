using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int? IdLibro { get; set; }
        public int? Votes { get; set; }

        public virtual Book IdLibroNavigation { get; set; }
    }
}
