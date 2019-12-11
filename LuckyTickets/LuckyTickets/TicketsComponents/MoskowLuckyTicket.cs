using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets.TicketsComponents
{
    public class MoskowLuckyTicket : ILuckyTicketsCounter
    {
        public bool IsLucky(Ticket usersTicket)
        {
            int firstHalfSum = 0;
            int secondHalfSum = 0;
            for (int i = 0; i < Ticket.HALF_TICKET_NUMBER; i++)
            {
                firstHalfSum += usersTicket.ticketNumber[i];
            }
            for (int i = Ticket.HALF_TICKET_NUMBER; i < Ticket.TICKETS_LENGTH; i++)
            {
                secondHalfSum += usersTicket.ticketNumber[i];
            }

            if (firstHalfSum == secondHalfSum)
            {
                return true;
            }

            return false;
        }
    }
}
