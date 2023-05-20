using System.ComponentModel.DataAnnotations;

namespace Foods1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
