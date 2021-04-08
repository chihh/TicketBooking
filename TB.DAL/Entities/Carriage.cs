using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Abstract;

namespace TB.DAL.Entities
{
    public class Carriage
    {
        int Id;
        List<bool> isFreeSpot = new List<bool>();
    }
}
