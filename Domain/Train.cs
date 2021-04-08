using System;
using System.Collections.Generic;

namespace Domain
{
    public class Train
    {
        int ID;
        bool isIntercity;
        List<Carriage> Carriages = new List<Carriage>();
        int routeID;
        DateTime date;
    }
}
