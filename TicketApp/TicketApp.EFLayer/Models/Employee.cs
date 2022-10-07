using System;
using System.Collections.Generic;

#nullable disable

namespace TicketApp.EFLayer.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Tickets = new HashSet<Ticket>();
        }

        public string Eid { get; set; }
        public string EName { get; set; }
        public DateTime? Doj { get; set; }
        public string Department { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
