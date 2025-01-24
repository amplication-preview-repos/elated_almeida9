using AgukaPlatformService.Core.Enums;

namespace AgukaPlatformService.APIs.Dtos;

public class Opportunity
{
    public bool? AddedToWorkOn { get; set; }

    public int? AgeRequirement { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? Deadline { get; set; }

    public string Id { get; set; }

    public string? Name { get; set; }

    public bool? OptionsSubscribed { get; set; }

    public string? Organizer { get; set; }

    public bool? ReminderSet { get; set; }

    public string? Topics { get; set; }

    public TypeFieldEnum? TypeField { get; set; }

    public DateTime UpdatedAt { get; set; }
}
