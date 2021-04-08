using System;
using System.Collections.Generic;
using System.Text;

namespace TB.DAL.Entities
{
    public class Ticket
    {
        DateTime DateTime { get; set; }
        String UserName { get; set; }
        int Id { get; set; }
        Seat Seat { get; set; }
        Station Start { get; set; }
        Station Finish { get; set; }


    }
}
