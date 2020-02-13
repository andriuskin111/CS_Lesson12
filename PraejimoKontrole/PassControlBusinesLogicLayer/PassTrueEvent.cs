using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class PassTrueEvent
    {
        public DateTime EventDate { get; private set; }

        public PassTrueEvent(DateTime eventDate)
        {
            EventDate = eventDate;
        }
    }
}
