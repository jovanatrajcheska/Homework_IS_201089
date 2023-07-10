using ISDomain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISDomain.DTO
{
    public class AddToShoppingCartDto
    {
        public Ticket Ticket { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
    }
}
