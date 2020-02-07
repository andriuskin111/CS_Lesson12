using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class EmployeeRepository
    {
        private List<Employee> _employeesList;

        public EmployeeRepository()
        {
            _employeesList = new List<Employee>();
            _employeesList.Add(new Employee(1, "Tom", "Cruise", new List<int> { 1, 2, 3 }));
            _employeesList.Add(new Employee(2, "Vasia", "Petrov", new List<int> { 4 }));
            _employeesList.Add(new Employee(3, "Andrius", "Petrauskas", new List<int> { 3 }));
            _employeesList.Add(new Employee(4, "Vytautas", "Jurkevicius", new List<int> { 2, 3 }));
            _employeesList.Add(new Employee(5, "Pamela", "Anderson", new List<int> { 3, 4 }));
            _employeesList.Add(new Employee(6, "Arnold", "Schvarcenegger", new List<int> { 1, 2 }));
            _employeesList.Add(new Employee(7, "Maryte", "Melnikaite", new List<int> { 1 }));
            _employeesList.Add(new Employee(8, "Eldar", "Ushadov", new List<int> { 2 }));
            _employeesList.Add(new Employee(9, "Vasilij", "Ivanovich", new List<int> { 3 }));
            _employeesList.Add(new Employee(10, "Valdemaras", "Chomicius", new List<int> { 2,4 }));
        }

        public Employee Retrieve(int employeeId)
        {
            foreach (var employee in _employeesList)
            {
                if(employeeId == employee.EmployeeId)
                {
                    return employee;
                }
            }

            return null;
        }

        public List<Employee> Retrieve()
        {
            return _employeesList;
        }
    }
}
