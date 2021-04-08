using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.BLL.Domain
{
    class TrainDomain
    {
        int Id;
        List<Carriage> Carriages = new List<Carriage>();
        Route Route { get; set; }
        DateTime date;
    }
}
