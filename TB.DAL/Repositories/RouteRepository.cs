using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;
using TB.DAL.Abstract;

namespace TB.DAL.Repositories
{
    class RouteRepository: GenericRepository<Route,int>, IRouteRepository
    {
        public RouteRepository(TicketBookingContext context) : base(context)
        {

        }
    }
}
