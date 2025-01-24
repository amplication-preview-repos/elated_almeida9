using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AgukaPlatformService.Core.Enums;

namespace AgukaPlatformService.Infrastructure.Models;

[Table("Opportunities")]
public class OpportunityDbModel
{
    public bool? AddedToWorkOn { get; set; }

    [Range(-999999999, 999999999)]
    public int? AgeRequirement { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? Deadline { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Name { get; set; }

    public bool? OptionsSubscribed { get; set; }

    [StringLength(1000)]
    public string? Organizer { get; set; }

    public bool? ReminderSet { get; set; }

    [StringLength(1000)]
    public string? Topics { get; set; }

    public TypeFieldEnum? TypeField { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
