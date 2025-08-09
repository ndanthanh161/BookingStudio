using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingStudio.BackendServer.Data.Entity
{
    [Table("Roles")]
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? UserRole { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
