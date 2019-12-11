using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets.TicketsComponents
{
    public class PiterLuckyNumber : ILuckyTicketsCounter
    {
        public bool IsLucky(Ticket usersTicket)
        {
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < Ticket.TICKETS_LENGTH; i++)
            {
                if(i % 2 == 1)
                {
                    oddSum += usersTicket.ticketNumber[i];
                    continue;
                }
                evenSum += usersTicket.ticketNumber[i];
            }

            if (oddSum == evenSum)
            {
                return true;
            }

            return false;
        }
    }
}
