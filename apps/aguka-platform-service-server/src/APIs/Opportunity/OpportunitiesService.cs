using AgukaPlatformService.Infrastructure;

namespace AgukaPlatformService.APIs;

public class OpportunitiesService : OpportunitiesServiceBase
{
    public OpportunitiesService(AgukaPlatformServiceDbContext context)
        : base(context) { }
}
