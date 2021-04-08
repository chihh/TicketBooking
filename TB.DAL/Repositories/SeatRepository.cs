using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Abstract;
using TB.DAL.Entities;

namespace TB.DAL.Repositories
{
    class SeatRepository : GenericRepository<Seat,int>, ISeatRepository
    {
        public SeatRepository(TicketBookingContext context) : base(context)
        {

        }
    }
}
