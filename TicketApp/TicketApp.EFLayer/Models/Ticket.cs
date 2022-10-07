using System;
using System.Collections.Generic;

#nullable disable

namespace TicketApp.EFLayer.Models
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public string LoggedBy { get; set; }
        public DateTime? RaisedDate { get; set; }
        public string Severity { get; set; }
        public string Tdescription { get; set; }
        public string ResolvedBy { get; set; }
        public string Resolution { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public bool? Tstatus { get; set; }

        public virtual Employee LoggedByNavigation { get; set; }
    }
}
