using AgukaPlatformService.APIs;
using AgukaPlatformService.APIs.Common;
using AgukaPlatformService.APIs.Dtos;
using AgukaPlatformService.APIs.Errors;
using Microsoft.AspNetCore.Mvc;

namespace AgukaPlatformService.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExamplesControllerBase : ControllerBase
{
    protected readonly IExamplesService _service;

    public ExamplesControllerBase(IExamplesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Example
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Example>> CreateExample(ExampleCreateInput input)
    {
        var example = await _service.CreateExample(input);

        return CreatedAtAction(nameof(Example), new { id = example.Id }, example);
    }

    /// <summary>
    /// Delete one Example
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteExample([FromRoute()] ExampleWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteExample(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Examples
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Example>>> Examples(
        [FromQuery()] ExampleFindManyArgs filter
    )
    {
        return Ok(await _service.Examples(filter));
    }

    /// <summary>
    /// Meta data about Example records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExamplesMeta(
        [FromQuery()] ExampleFindManyArgs filter
    )
    {
        return Ok(await _service.ExamplesMeta(filter));
    }

    /// <summary>
    /// Get one Example
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Example>> Example([FromRoute()] ExampleWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Example(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Example
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateExample(
        [FromRoute()] ExampleWhereUniqueInput uniqueId,
        [FromQuery()] ExampleUpdateInput exampleUpdateDto
    )
    {
        try
        {
            await _service.UpdateExample(uniqueId, exampleUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
