using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Route
    {
        int Id { get; set; }
        List<Station> Stations = new List<Station>();
    }
}
