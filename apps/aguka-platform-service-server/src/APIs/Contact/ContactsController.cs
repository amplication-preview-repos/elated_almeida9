using Microsoft.AspNetCore.Mvc;

namespace AgukaPlatformService.APIs;

[ApiController()]
public class ContactsController : ContactsControllerBase
{
    public ContactsController(IContactsService service)
        : base(service) { }
}
