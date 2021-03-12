using ContactManager.Models;
using ContactManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {


        //private ContactRepository contactRepository;
        ////GET api/<controller>

        //public ContactController()
        //{
        //    this.contactRepository = new ContactRepository();
        //}

        //public Contact[] Get()
        //{

        //    return contactRepository.GetAllContacts();
        //}

        // GET api/<controller>
        public IEnumerable<Contact> Get()
        {
            return new Contact[] {
              new Contact
        {
            Id = 1,
            Name = "Glenn Block"
        },
        new Contact
        {
            Id = 2,
            Name = "Dan Roth"
        }
            };

        }





        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
