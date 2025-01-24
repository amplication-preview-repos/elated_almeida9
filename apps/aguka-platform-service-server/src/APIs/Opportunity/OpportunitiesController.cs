using Microsoft.AspNetCore.Mvc;

namespace AgukaPlatformService.APIs;

[ApiController()]
public class OpportunitiesController : OpportunitiesControllerBase
{
    public OpportunitiesController(IOpportunitiesService service)
        : base(service) { }
}
