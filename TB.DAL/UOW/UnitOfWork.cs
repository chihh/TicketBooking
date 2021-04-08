using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Abstract;

namespace TB.DAL.UOW
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly TicketBookingContext context;
        public ISeatRepository Seats { get; }

        public ITicketRepository Tickets { get; }

        public ITrainRepository Trains { get; }

        public ICarriageRepository Carriages { get; }

        public IStationRepository Stations { get; }

        public IRouteRepository Routes { get; }

        public UnitOfWork (TicketBookingContext context, ISeatRepository seatRepository, ITicketRepository ticketRepository,
            ITrainRepository trainRepository, ICarriageRepository carriageRepository, IStationRepository stationRepository,
            IRouteRepository routeRepository)
        {
            this.context = context;
            Seats = seatRepository;
            Tickets = ticketRepository;
            Trains = trainRepository;
            Carriages = carriageRepository;
            Stations = stationRepository;
            Routes = routeRepository;
        }

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
