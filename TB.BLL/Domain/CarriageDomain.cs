using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.BLL.Domain
{
    class CarriageDomain
    {
        int Id;
        List<bool> isFreeSpot = new List<bool>();
    }
}
