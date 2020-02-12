using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class RaportGenerator
    {
        private EmployeeRepository _employeeRepository;
        private GateRepository _gateRepository;
        private EventController _eventController;

        public RaportGenerator(EmployeeRepository employeeRepository, GateRepository gateRepository, EventController eventController)
        {
            _employeeRepository = employeeRepository;
            _gateRepository = gateRepository;
            _eventController = eventController;
        }

        public List<RaportEvent> GenerateRaport()
        {
            List<RaportEvent> result = new List<RaportEvent>();            

            foreach (var item in _eventController.Retrieve())
            {
                string employeeName = "";
                string gateDescription = "";

                Gate gate = _gateRepository.Retrieve(item.GateId);

                foreach (var employee in _employeeRepository.Retrieve())
                {
                    if(item.EmployeeId == employee.EmployeeId)
                    {
                        employeeName = employee.EmployeeName;
                        gateDescription = gate.GateDescription;                     
                    }
                }

                result.Add(new RaportEvent(employeeName, gateDescription, item.EventDate, item.Pass));
            }

            return result;
        }
    }
}
