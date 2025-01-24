using AgukaPlatformService.APIs.Common;
using AgukaPlatformService.APIs.Dtos;

namespace AgukaPlatformService.APIs;

public interface IExamplesService
{
    /// <summary>
    /// Create one Example
    /// </summary>
    public Task<Example> CreateExample(ExampleCreateInput example);

    /// <summary>
    /// Delete one Example
    /// </summary>
    public Task DeleteExample(ExampleWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Examples
    /// </summary>
    public Task<List<Example>> Examples(ExampleFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Example records
    /// </summary>
    public Task<MetadataDto> ExamplesMeta(ExampleFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Example
    /// </summary>
    public Task<Example> Example(ExampleWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Example
    /// </summary>
    public Task UpdateExample(ExampleWhereUniqueInput uniqueId, ExampleUpdateInput updateDto);
}
