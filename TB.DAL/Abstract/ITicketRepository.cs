﻿using System;
using System.Collections.Generic;
using System.Text;
using TB.DAL.Entities;

namespace TB.DAL.Abstract
{
    public interface ITicketRepository: IRepository<Ticket,int>
    {
    }
}
