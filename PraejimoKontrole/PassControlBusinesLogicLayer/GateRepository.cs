using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class GateRepository
    {
        private List<Gate> _gatesList;

        public GateRepository()
        {
            _gatesList = new List<Gate>();
            _gatesList.Add(new Gate(1, "01", "Green color Gate"));
            _gatesList.Add(new Gate(2, "02", "Red color Gate"));
            _gatesList.Add(new Gate(3, "03", "Blue color Gate"));
            _gatesList.Add(new Gate(4, "04", "Yellow color Gate"));
        }

        public Gate Retrieve(int gateId)
        {
            foreach (var gate in _gatesList)
            {
                if(gateId == gate.GateId)
                {
                    return gate;
                }
            }

            return null;
        }

        public List<Gate> Retrieve()
        {
            return _gatesList;
        }
    }

}
