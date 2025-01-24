using AgukaPlatformService.Core.Enums;

namespace AgukaPlatformService.APIs.Dtos;

public class ExampleCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Description { get; set; }

    public string? Id { get; set; }

    public TypeFieldEnum? TypeField { get; set; }

    public DateTime UpdatedAt { get; set; }
}
