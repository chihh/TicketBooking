using System;
using System.Collections.Generic;
using System.Text;

namespace TB.DAL.Entities
{
    public class Route
    {
        int Id { get; set; }
        List<Station> Stations = new List<Station>();
    }
}
