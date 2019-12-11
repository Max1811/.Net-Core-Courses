using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets.TicketsComponents
{
    public interface ILuckyTicketsCounter
    {
        bool IsLucky(Ticket usersTicket);
    }
}
