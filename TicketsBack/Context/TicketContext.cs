using System;
using Microsoft.EntityFrameworkCore;
using TicketsBack.Models;

namespace TicketsBack.Context
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
    }


}
