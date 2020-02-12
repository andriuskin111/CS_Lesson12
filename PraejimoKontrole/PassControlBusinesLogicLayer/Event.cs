using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class Event
    {
        public Guid EventId { get; private set; }
        public int EmployeeId { get; private set; }
        public int GateId { get; private set; }
        public DateTime EventDate { get; private set; }
        public bool Pass { get; private set; }

        public Event(Guid eventId, int employeeId, int gateId, DateTime eventDate, bool pass)
        {
            EventId = eventId;
            EmployeeId = employeeId;
            GateId = gateId;
            EventDate = eventDate;
            Pass = pass;
        }
    }
}
