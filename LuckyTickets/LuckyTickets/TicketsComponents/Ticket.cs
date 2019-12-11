using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets.TicketsComponents
{
    public class Ticket: TicketComponents
    {
        public int[] ticketNumber { get; protected set; }

        public AlgorithmsCases algorithmName;

        public ILuckyTicketsCounter countMethod;

        public Ticket(string usersInput, AlgorithmsCases algorithm, ILuckyTicketsCounter countMethod)
        {
            ticketNumber = TryParseString(usersInput);
            algorithmName = algorithm;
            this.countMethod = countMethod;
        }

        public int[] TryParseString(string usersInput)
        {
            if (usersInput.Length <= Ticket.TICKETS_LENGTH && usersInput != null)
            {
                ticketNumber = new int[Ticket.TICKETS_LENGTH];
                try
                {
                    int number = Convert.ToInt32(usersInput);
                    for (int symbol = Ticket.TICKETS_LENGTH - 1; symbol >= Ticket.TICKETS_LENGTH - usersInput.Length; symbol--)
                    {
                        ticketNumber[symbol] = number % 10;
                        number /= Ticket.RANK_DIVIDER;
                    }
                }
                catch
                {
                    return null;
                }

                return ticketNumber;
            }

            return null;
        }
    }
}
