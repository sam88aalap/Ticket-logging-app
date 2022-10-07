using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.CommonLayer.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTimeOffset HireDate { get; set; }
        public int MyProperty { get; set; }
    }
}
