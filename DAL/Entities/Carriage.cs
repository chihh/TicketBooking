using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstract;

namespace DAL.Entities
{
    class Carriage: Base
    {
        int Id;
        List<bool> isFreeSpot = new List<bool>();
    }
}
