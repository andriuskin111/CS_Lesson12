using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class RaportEvent
    {
        public string EmployeeName { get; private set; }
        public string GateDescriprion { get; private set; }
        public string EventDate { get; private set; }
        public string Pass { get; private set; }

        public RaportEvent(string employeeName, string gateDescription, DateTime eventDate, bool pass)
        {
            EmployeeName = employeeName;
            GateDescriprion = gateDescription;
            EventDate = eventDate.ToString();

            if(pass == true)
            {
                Pass = "Granted";
            }
            else
            {
                Pass = "Denied";
            }
            
        }
    }
}
