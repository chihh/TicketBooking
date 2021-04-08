using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;
using TB.DAL.Abstract;

namespace TB.DAL.Repositories
{
    class TrainRepository: GenericRepository<Train,int>, ITrainRepository
    {
        public TrainRepository(TicketBookingContext context) : base(context)
        {

        }
    }
}
