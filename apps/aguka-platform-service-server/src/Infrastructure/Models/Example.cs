using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AgukaPlatformService.Core.Enums;

namespace AgukaPlatformService.Infrastructure.Models;

[Table("Examples")]
public class ExampleDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public TypeFieldEnum? TypeField { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
