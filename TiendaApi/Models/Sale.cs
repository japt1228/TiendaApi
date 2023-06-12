using System.ComponentModel.DataAnnotations;

namespace TiendaApi.Models
{
    public class Sale
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required]
        public List<Product> Products { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public User User { get; set; }

    }
}
