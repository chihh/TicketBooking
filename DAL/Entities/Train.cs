using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Train
    {
        int Id;
        List<Carriage> Carriages = new List<Carriage>();
        Route Route { get; set; }
        DateTime date;
    }
}
