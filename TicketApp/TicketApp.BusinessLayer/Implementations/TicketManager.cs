using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.BusinessLayer.Contracts;
using TicketApp.CommonLayer.Models;
using TicketApp.EFLayer.Contracts;

namespace TicketApp.BusinessLayer.Implementations
{
    public class TicketManager : ITicketManager
    {

        private readonly ITicketRepository ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }


        public bool AddTicket(Ticket ticket)
        {
            try
            {
                return ticketRepository.AddTicket(ticket);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Ticket> GetTickets()
        {
            throw new NotImplementedException();
        }

        public bool UpdateTicket(Ticket ticket)
        {
            try
            {
                return ticketRepository.UpdateTicket(ticket);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
