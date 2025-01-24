using AgukaPlatformService.APIs.Dtos;
using AgukaPlatformService.Infrastructure.Models;

namespace AgukaPlatformService.APIs.Extensions;

public static class ExamplesExtensions
{
    public static Example ToDto(this ExampleDbModel model)
    {
        return new Example
        {
            CreatedAt = model.CreatedAt,
            Description = model.Description,
            Id = model.Id,
            TypeField = model.TypeField,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ExampleDbModel ToModel(
        this ExampleUpdateInput updateDto,
        ExampleWhereUniqueInput uniqueId
    )
    {
        var example = new ExampleDbModel
        {
            Id = uniqueId.Id,
            Description = updateDto.Description,
            TypeField = updateDto.TypeField
        };

        if (updateDto.CreatedAt != null)
        {
            example.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            example.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return example;
    }
}
