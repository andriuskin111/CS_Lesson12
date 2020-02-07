using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class EventController
    {
        private List<Event> _eventsList;
        private EmployeeRepository _employeeRepository;

        public EventController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public bool TryPass(int employeeId, int gateId)
        {
            Employee employee = _employeeRepository.Retrieve(employeeId);

            return employee.HasRights(gateId);
            
        }

        public void GenerateNewEvent()
        {

        }
    }
}
