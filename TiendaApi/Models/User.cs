using System.ComponentModel.DataAnnotations;

namespace TiendaApi.Models
{
    public enum Role
    {
        Administrator,
        Seller
    }
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Role Role { get; set; }
    }
}
