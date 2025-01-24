using AgukaPlatformService.APIs.Dtos;
using AgukaPlatformService.Infrastructure.Models;

namespace AgukaPlatformService.APIs.Extensions;

public static class OpportunitiesExtensions
{
    public static Opportunity ToDto(this OpportunityDbModel model)
    {
        return new Opportunity
        {
            AddedToWorkOn = model.AddedToWorkOn,
            AgeRequirement = model.AgeRequirement,
            CreatedAt = model.CreatedAt,
            Deadline = model.Deadline,
            Id = model.Id,
            Name = model.Name,
            OptionsSubscribed = model.OptionsSubscribed,
            Organizer = model.Organizer,
            ReminderSet = model.ReminderSet,
            Topics = model.Topics,
            TypeField = model.TypeField,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OpportunityDbModel ToModel(
        this OpportunityUpdateInput updateDto,
        OpportunityWhereUniqueInput uniqueId
    )
    {
        var opportunity = new OpportunityDbModel
        {
            Id = uniqueId.Id,
            AddedToWorkOn = updateDto.AddedToWorkOn,
            AgeRequirement = updateDto.AgeRequirement,
            Deadline = updateDto.Deadline,
            Name = updateDto.Name,
            OptionsSubscribed = updateDto.OptionsSubscribed,
            Organizer = updateDto.Organizer,
            ReminderSet = updateDto.ReminderSet,
            Topics = updateDto.Topics,
            TypeField = updateDto.TypeField
        };

        if (updateDto.CreatedAt != null)
        {
            opportunity.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            opportunity.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return opportunity;
    }
}
