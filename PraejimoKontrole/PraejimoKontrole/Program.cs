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
                Console.WriteLine("Select operation [1]-Add Event, [2]-Show All Events, [3]-Show total Hours");

                if(!int.TryParse(Console.ReadLine(), out int operation))
                {
                    Console.WriteLine("Entered data incorrect!");
                }
                else
                {
                    if (operation == 1)
                    {
                        Console.WriteLine("Enter Employee Id:");
                        int employeeId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Gate Id:");
                        int gateId = int.Parse(Console.ReadLine());

                        eventController.TryPass(employeeId, gateId);
                    }
                    else if (operation == 2)
                    {
                        ShowRaport(raportGenerator);
                    }
                    else if (operation == 3)
                    {
                        ShowTotalHousr(raportGenerator);
                    }
                    else
                    {
                        Console.WriteLine("Wrong operation! Please try again...");
                    }
                }               
            }
        }

        private static void ShowTotalHousr(RaportGenerator raportGenerator)
        {
            foreach (var item in raportGenerator.GenerateTotalHours())
            {
                Console.WriteLine($"Name: {item.EmployeeName}, Total Hours: {item.TotalHours}");
            }
        }

        private static void ShowRaport(RaportGenerator raportGenerator)
        {
            if(raportGenerator.GenerateRaport().Count < 1)
            {
                Console.WriteLine("No Events present!");
            }
            else
            {
                foreach (var item in raportGenerator.GenerateRaport())
                {
                    Console.WriteLine($"Name: {item.EmployeeName}, Gate: {item.GateDescriprion}" +
                        $", Date: {item.EventDate}, Access {item.Pass}");
                }
            }           
        }
    }
}
