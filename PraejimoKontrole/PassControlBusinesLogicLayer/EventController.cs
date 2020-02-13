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
            _eventsList = new List<Event>();
        }

        public bool TryPass(int employeeId, int gateId)
        {
            Employee employee = _employeeRepository.Retrieve(employeeId);
            
            _eventsList.Add(new Event(Guid.NewGuid(), employeeId, gateId, DateTime.Now, employee.HasRights(gateId)));

            if (employee.HasRights(gateId) == true)
            {
                employee.PassTrueEvents.Add(new PassTrueEvent(DateTime.Now));
            }
            
            return employee.HasRights(gateId);
            
        }

        public List<Event> Retrieve()
        {
            return _eventsList;
        }
    }
}
