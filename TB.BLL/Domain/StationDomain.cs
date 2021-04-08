using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.BLL.Domain
{
    class StationDomain
    {
        int Id { get; set; }
        DateTime Time { get; set; }
        String Name { get; set; }
        //public (String name, DateTime time)
        //{
        //    this.Name = name;
        //    this.Time = time;
        //}
    }
}
