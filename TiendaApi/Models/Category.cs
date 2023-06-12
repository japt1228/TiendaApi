using System.ComponentModel.DataAnnotations;

namespace TiendaApi.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
