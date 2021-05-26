using ContactApp.Model;
using ContactApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactServices _contactServices;

        public ContactController(IContactServices contactServices)
        {
            _contactServices = contactServices;
        }

        [HttpGet]
        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _contactServices.Get();
        }

        [HttpGet("Id/{Id}")]
        public async Task<ActionResult<Contact>> GetById(int Id)
        {
            try
            {
                return await _contactServices.GetById(Id);
            }catch
            {
                return NotFound();
            }

        }

        [HttpGet("email/{email}")]
        public async Task<ActionResult<Contact>> GetByemail(string email)
        {
                return await _contactServices.GetByEmail(email);
        }

        [HttpPost("/add-new")]
        public async Task<ActionResult> CreateUser([FromBody] Contact contact)
        {
            var newContact = await _contactServices.Create(contact);
            return CreatedAtAction(nameof(GetContacts), new { id = newContact.Id }, newContact);
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePhoto(int Id, [FromBody] Contact contact)
        {
            if (Id != contact.Id)
            {
                return BadRequest();
            }

            await _contactServices.Update(contact);
            return NoContent();
        }

        [HttpDelete("/delete/Id/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var contactToDelete = await _contactServices.GetById(id);
            if (contactToDelete == null)
            {
                return NotFound();
            }

            await _contactServices.Delete(contactToDelete);
            return NoContent();
        }
    }
}
