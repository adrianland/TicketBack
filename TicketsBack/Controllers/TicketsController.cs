using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketsBack.Context;
using TicketsBack.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketsBack.Controllers
{
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        private readonly TicketContext _TicketContext;

        public TicketsController(TicketContext ticketContext)
        {
            _TicketContext = ticketContext;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return _TicketContext.Tickets;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Ticket Get(int id)
        {
            return _TicketContext.Tickets.SingleOrDefault(t => t.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Ticket value)
        {
            _TicketContext.Tickets.Add(value);
            _TicketContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ticket value)
        {

            value.Id = id;
            _TicketContext.Entry(value).State = EntityState.Modified;
            _TicketContext.SaveChanges();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ticket = _TicketContext.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticket != null)
            {
                _TicketContext.Tickets.Remove(ticket);
                _TicketContext.SaveChanges();
            }
        }
    }
}
