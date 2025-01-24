using AgukaPlatformService.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AgukaPlatformService.Infrastructure;

public class AgukaPlatformServiceDbContext : DbContext
{
    public AgukaPlatformServiceDbContext(DbContextOptions<AgukaPlatformServiceDbContext> options)
        : base(options) { }

    public DbSet<OpportunityDbModel> Opportunities { get; set; }

    public DbSet<ContactDbModel> Contacts { get; set; }

    public DbSet<ExampleDbModel> Examples { get; set; }
}
