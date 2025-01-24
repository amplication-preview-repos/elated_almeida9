using AgukaPlatformService.Infrastructure;

namespace AgukaPlatformService.APIs;

public class ContactsService : ContactsServiceBase
{
    public ContactsService(AgukaPlatformServiceDbContext context)
        : base(context) { }
}
