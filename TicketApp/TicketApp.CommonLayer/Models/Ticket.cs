using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.CommonLayer.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string LoggedBy { get; set; }
        public DateTimeOffset TicketDate { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
        public string ResolvedBy { get; set; }
        public string Resolution { get; set; }
        public DateTimeOffset ResolveDate { get; set; }
        public bool Status { get; set; }

    }
}
