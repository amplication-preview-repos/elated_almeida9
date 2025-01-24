using Microsoft.AspNetCore.Mvc;

namespace AgukaPlatformService.APIs;

[ApiController()]
public class ExamplesController : ExamplesControllerBase
{
    public ExamplesController(IExamplesService service)
        : base(service) { }
}
