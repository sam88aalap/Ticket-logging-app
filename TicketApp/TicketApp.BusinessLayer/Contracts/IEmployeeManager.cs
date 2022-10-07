using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.CommonLayer.Models;

namespace TicketApp.BusinessLayer.Contracts
{
    interface IEmployeeManager
    {
        bool AddEmployee(Employee employee);
        List<Ticket> GetEmployee();
    }
}
