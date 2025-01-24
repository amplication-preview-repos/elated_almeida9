using AgukaPlatformService.APIs;
using AgukaPlatformService.APIs.Common;
using AgukaPlatformService.APIs.Dtos;
using AgukaPlatformService.APIs.Errors;
using AgukaPlatformService.APIs.Extensions;
using AgukaPlatformService.Infrastructure;
using AgukaPlatformService.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AgukaPlatformService.APIs;

public abstract class ExamplesServiceBase : IExamplesService
{
    protected readonly AgukaPlatformServiceDbContext _context;

    public ExamplesServiceBase(AgukaPlatformServiceDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Example
    /// </summary>
    public async Task<Example> CreateExample(ExampleCreateInput createDto)
    {
        var example = new ExampleDbModel
        {
            CreatedAt = createDto.CreatedAt,
            Description = createDto.Description,
            TypeField = createDto.TypeField,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            example.Id = createDto.Id;
        }

        _context.Examples.Add(example);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ExampleDbModel>(example.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Example
    /// </summary>
    public async Task DeleteExample(ExampleWhereUniqueInput uniqueId)
    {
        var example = await _context.Examples.FindAsync(uniqueId.Id);
        if (example == null)
        {
            throw new NotFoundException();
        }

        _context.Examples.Remove(example);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Examples
    /// </summary>
    public async Task<List<Example>> Examples(ExampleFindManyArgs findManyArgs)
    {
        var examples = await _context
            .Examples.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return examples.ConvertAll(example => example.ToDto());
    }

    /// <summary>
    /// Meta data about Example records
    /// </summary>
    public async Task<MetadataDto> ExamplesMeta(ExampleFindManyArgs findManyArgs)
    {
        var count = await _context.Examples.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Example
    /// </summary>
    public async Task<Example> Example(ExampleWhereUniqueInput uniqueId)
    {
        var examples = await this.Examples(
            new ExampleFindManyArgs { Where = new ExampleWhereInput { Id = uniqueId.Id } }
        );
        var example = examples.FirstOrDefault();
        if (example == null)
        {
            throw new NotFoundException();
        }

        return example;
    }

    /// <summary>
    /// Update one Example
    /// </summary>
    public async Task UpdateExample(ExampleWhereUniqueInput uniqueId, ExampleUpdateInput updateDto)
    {
        var example = updateDto.ToModel(uniqueId);

        _context.Entry(example).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Examples.Any(e => e.Id == example.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
