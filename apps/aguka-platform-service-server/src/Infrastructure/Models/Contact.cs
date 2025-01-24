using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgukaPlatformService.Infrastructure.Models;

[Table("Contacts")]
public class ContactDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public string? Email { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Name { get; set; }

    [StringLength(1000)]
    public string? RoleRelation { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
