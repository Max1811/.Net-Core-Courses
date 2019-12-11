using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets.TicketsComponents
{
    public abstract class TicketComponents
    {
        public static readonly int TICKETS_LENGTH = 6;

        public static readonly int RANK_DIVIDER = 10;

        public static readonly int HALF_TICKET_NUMBER = TICKETS_LENGTH / 2;
    }
}
