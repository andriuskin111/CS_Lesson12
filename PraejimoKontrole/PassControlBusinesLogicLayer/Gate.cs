using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class Gate
    {
        public int GateId { get; private set; }
        public string GateCode { get; private set; }
        public string GateDescription { get; private set; }

        public Gate(int gateId, string gateCode, string gateDescription)
        {
            GateId = gateId;
            GateCode = gateCode;
            GateDescription = gateDescription;    
        }
    }
}
