using AgukaPlatformService.Infrastructure;

namespace AgukaPlatformService.APIs;

public class ExamplesService : ExamplesServiceBase
{
    public ExamplesService(AgukaPlatformServiceDbContext context)
        : base(context) { }
}
