using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.CommonLayer.Models;
using TicketApp.EFLayer.Contracts;
using TicketApp.EFLayer.Models;

namespace TicketApp.EFLayer.Implementations
{
    public class TicketRepositoryImpl : ITicketRepository
    {
        private readonly db_ticketappContext context = null;

        public TicketRepositoryImpl(db_ticketappContext context)
        {
           
            this.context = context;
        }

        int tId = 1;
        public bool AddTicket(CommonLayer.Models.Ticket ticket)
        {
            bool isAdded = false;
            

            try
            {
                var ticketDb = new Models.Ticket()
                {
                    TicketId=tId++,
                    LoggedBy=ticket.LoggedBy,
                    RaisedDate=ticket.TicketDate.UtcDateTime,
                    Severity=ticket.Severity,
                    Tdescription=ticket.Description,
                    Resolution=ticket.Resolution,
                    ResolvedDate=ticket.ResolveDate.UtcDateTime,
                    Tstatus=ticket.Status

                };

                this.context.Tickets.Add(ticketDb);
                this.context.SaveChanges();
                isAdded = true;
            }
            catch (Exception)
            {

                throw;
            }

            return isAdded;

        }

      
        public bool UpdateTicket(CommonLayer.Models.Ticket ticket)
        {
            bool isUpdated = false;

            try
            {
                var ticketToUpdate = this.context.Tickets.FirstOrDefault(x => x.TicketId == ticket.TicketId);
                if (ticketToUpdate == null)
                {
                    Console.WriteLine("ticket not found");
                }
                else
                {

                    ticketToUpdate.ResolvedBy = ticket.ResolvedBy;
                    ticketToUpdate.Resolution = ticket.Resolution;
                    ticketToUpdate.ResolvedDate = ticket.ResolveDate.UtcDateTime;
                    ticketToUpdate.Tstatus = ticket.Status;


                    this.context.SaveChanges();
                    isUpdated = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return isUpdated;
        }

       
    }
}
