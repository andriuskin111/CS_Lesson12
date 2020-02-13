using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string EmployeeName { get; private set; }
        public string EmployeeSurename { get; private set; }
        public List<PassTrueEvent> PassTrueEvents { get; private set; }

        private List<int> _gateRights;      

        public Employee(int employeeId, string employeeName, string employeeSurename, List<int> gateRights, List<PassTrueEvent> passTrueEvents)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeSurename = employeeSurename;
            _gateRights = gateRights;
            PassTrueEvents = passTrueEvents;
        }

        public bool HasRights(int gateId)
        {
            foreach (var rightsId in _gateRights)
            {               
                if(rightsId == gateId)
                {
                    return true;
                }
            }

            return false;
        }

        public double GetTotalHours()
        {
            double result = 0;
            int iterationCount;
            int count = 0;

            if(PassTrueEvents.Count % 2 != 0)
            {
                iterationCount = PassTrueEvents.Count - 1;
            }
            else
            {
                iterationCount = PassTrueEvents.Count;
            }

            if(PassTrueEvents.Count > 0)
            {
                for (int i = 0; i < iterationCount; i++)
                {
                    count++;

                    if (count == 2)
                    {
                        result += (PassTrueEvents[i].EventDate - PassTrueEvents[i - 1].EventDate).TotalHours;
                        count = 0;
                    }                   
                }
            }
            
            return result;
        }
    }
}
