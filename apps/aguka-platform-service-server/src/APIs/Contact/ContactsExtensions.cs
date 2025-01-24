using AgukaPlatformService.APIs.Dtos;
using AgukaPlatformService.Infrastructure.Models;

namespace AgukaPlatformService.APIs.Extensions;

public static class ContactsExtensions
{
    public static Contact ToDto(this ContactDbModel model)
    {
        return new Contact
        {
            CreatedAt = model.CreatedAt,
            Email = model.Email,
            Id = model.Id,
            Name = model.Name,
            RoleRelation = model.RoleRelation,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ContactDbModel ToModel(
        this ContactUpdateInput updateDto,
        ContactWhereUniqueInput uniqueId
    )
    {
        var contact = new ContactDbModel
        {
            Id = uniqueId.Id,
            Email = updateDto.Email,
            Name = updateDto.Name,
            RoleRelation = updateDto.RoleRelation
        };

        if (updateDto.CreatedAt != null)
        {
            contact.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            contact.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return contact;
    }
}
