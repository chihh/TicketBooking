using System;
using System.Collections.Generic;
using System.Text;

namespace TB.DAL.Entities
{
    public class Station
    {
        int Id { get; set; }
        DateTime Time { get; set; }
        String Name { get; set; }
        public Station (String name, DateTime time) {
            this.Name=name;
            this.Time=time;
        }
    }
}
