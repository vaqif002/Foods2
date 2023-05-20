using System.ComponentModel.DataAnnotations;

namespace Foods1.Models
{
    public class Category
    {
        public Category()
        {
            List<Category> list = new List<Category>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool IsDelected { get; set; }
        List<Product> Products { get; set; }
    }
}
