using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.BLL.Domain
{
    class RouteDomain
    {
        int Id { get; set; }
        List<Station> Stations = new List<Station>();
    }
}
