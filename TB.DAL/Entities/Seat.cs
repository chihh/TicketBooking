using System;
using System.Collections.Generic;
using System.Text;

namespace TB.DAL.Entities
{
    public class Seat
    {
        int Id { get; set; }
        int Number { get; set; }
        Carriage Carriage { get; set; }
    }
}
