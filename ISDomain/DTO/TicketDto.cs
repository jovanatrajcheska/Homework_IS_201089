using ISDomain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISDomain.DTO
{
    public class TicketDto
    {
        public List<Ticket> Tickets { get; set; }
        public DateTime Date { get; set; }
    }
}
