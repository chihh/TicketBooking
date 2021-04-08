using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Seat
    {
        int Id { get; set; }
        int Number { get; set; }
        Carriage Carriage { get; set; }
    }
}
