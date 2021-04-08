using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.BLL.Domain
{
    class SeatDomain
    {
        int Id { get; set; }
        int Number { get; set; }
        Carriage Carriage { get; set; }
    }
}
