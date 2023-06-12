using System.ComponentModel.DataAnnotations;

namespace TiendaApi.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public Provider Provider { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
