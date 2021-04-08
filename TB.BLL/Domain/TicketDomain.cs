using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.BLL.Domain
{
    public class TicketDomain
    {
        DateTime DateTime { get; set; }
        String UserName { get; set; }
        int Id { get; set; }
        Seat Seat { get; set; }
        Station Start { get; set; }
        Station Finish { get; set; }
    }
}
