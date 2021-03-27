using ContactsService.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContactsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly ILogger<ContactsController> _logger;
        private readonly IContactsProvider _contactsProvider;

        public ContactsController(ILogger<ContactsController> logger, IContactsProvider contactsProvider)
        {
            _logger = logger;
            _contactsProvider = contactsProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var contacts = _contactsProvider.GetContacts();

            return Ok(contacts);
        }
    }
}
