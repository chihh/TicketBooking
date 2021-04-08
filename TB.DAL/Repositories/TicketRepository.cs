using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;
using TB.DAL.Abstract;

namespace TB.DAL.Repositories
{
    class TicketRepository: GenericRepository<Ticket,int>, ITicketRepository
    {
        public TicketRepository(TicketBookingContext context) : base(context)
        {

        }
    }
}
