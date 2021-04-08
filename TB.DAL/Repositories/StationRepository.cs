using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;
using TB.DAL.Abstract;

namespace TB.DAL.Repositories
{
    class StationRepository: GenericRepository<Station,int>, IStationRepository
    {
        public StationRepository(TicketBookingContext context) : base(context)
        {

        }
    }
}
