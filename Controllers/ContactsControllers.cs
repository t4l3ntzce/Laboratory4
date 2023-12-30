using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Task03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        public static NoteBook _notebook = new NoteBook();

        // GET: api/<ContactController>
        [HttpGet(Name = "GetContacts")]
        public IEnumerable<Contact> GetContacts()
        {
            return _notebook.GetAllContacts();
        }

        // POST api/<ContactController>
        [HttpPost(Name = "AddContact")]
        public IActionResult AddContact(Contact contact)
        {
            _notebook.AddNewContact(contact);

            return Ok(contact);
        }
    }
}