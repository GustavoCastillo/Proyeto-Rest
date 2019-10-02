using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    // ModelBinding
    public class Popular
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int? Category { get; set; }
        public int? Votes { get; set; }
    }
}