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

        private List<int> _gateRights;

        public Employee(int employeeId, string employeeName, string employeeSurename, List<int> gateRights)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeSurename = employeeSurename;
            _gateRights = gateRights;
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
    }
}
