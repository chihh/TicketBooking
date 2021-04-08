using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;
using TB.DAL.Abstract;

namespace TB.DAL.Repositories
{
    class CarriageRepository: GenericRepository<Carriage,int>, ICarriageRepository
    {
        public CarriageRepository(TicketBookingContext context) : base(context)
        {

        }
    }
}
