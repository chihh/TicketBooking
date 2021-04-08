using System;
using System.Collections.Generic;
using System.Text;

namespace TB.DAL.Abstract
{
    public interface IUnitOfWork 
    {
        ISeatRepository Seats { get; }
        ITicketRepository Tickets { get; }
        ITrainRepository Trains { get; }
        ICarriageRepository Carriages { get; }
        IStationRepository Stations { get; }
        IRouteRepository Routes { get; }

        void Save();
    }
}
