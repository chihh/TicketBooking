using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Ticket
    {
        DateTime Date_time { get; set; }
        String User_name { get; set}
        int Id { get; set; }
        Seat Seat { get; set; }
        Station Start { get; set; }
        Station Finish { get; set; }


    }
}
