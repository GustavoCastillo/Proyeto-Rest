using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public partial class Book
    {
        public Book()
        {
            Review = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public int? Category { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
