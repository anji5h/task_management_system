using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementAPI.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public partial class UserModel : AuditModelWithSoftDelete
    {
        public UserModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "text")]
        public string Password { get; set; } = string.Empty;

        [Required]
        public DateTimeOffset LastLogin { get; set; }
    }
}