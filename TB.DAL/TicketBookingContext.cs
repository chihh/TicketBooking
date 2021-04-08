using System;
using System.Data.Entity;
using TB.DAL.Entities;

namespace TB.DAL
{
    public class TicketBookingContext: DbContext
    {
        public DbSet<Train> Trains { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Carriage> Carriages { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        static TicketBookingContext()
        {
        //    Database.SetInitializer<TicketBookingContext>(new DbInitializer);
        }

    }
}
