using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlBusinesLogicLayer
{
    public class RaportTotalHours
    {
        public string EmployeeName { get; private set; }
        public double TotalHours { get; private set; }

        public RaportTotalHours(string employeeName, double totalHours)
        {
            EmployeeName = employeeName;
            TotalHours = totalHours;
        }

    }
}
