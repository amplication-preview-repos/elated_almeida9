using AgukaPlatformService.APIs.Common;
using AgukaPlatformService.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgukaPlatformService.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class ContactFindManyArgs : FindManyInput<Contact, ContactWhereInput> { }
