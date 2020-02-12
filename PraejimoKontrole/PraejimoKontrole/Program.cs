using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassControlBusinesLogicLayer;

namespace PassControl
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            GateRepository gateRepository = new GateRepository();
            EventController eventController = new EventController(employeeRepository);
            RaportGenerator raportGenerator = new RaportGenerator(employeeRepository, gateRepository, eventController);

            while (true)
            {
                Console.WriteLine("Enter Employee Id:");
                int employeeId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Gate Id:");
                int gateId = int.Parse(Console.ReadLine());

                eventController.TryPass(employeeId, gateId);

                foreach (var item in raportGenerator.GenerateRaport())
                {
                    Console.WriteLine($"Name: {item.EmployeeName}, Gate: {item.GateDescriprion}" +
                        $", Date: {item.EventDate}, Access {item.Pass}");
                }
            }
        }
    }
}
