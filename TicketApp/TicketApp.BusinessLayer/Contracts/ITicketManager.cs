using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.CommonLayer.Models;

namespace TicketApp.BusinessLayer.Contracts
{
    public interface ITicketManager
    {
        bool AddTicket(Ticket ticket);

        bool UpdateTicket(Ticket ticket);
        List<Ticket> GetTickets();
    }
}
