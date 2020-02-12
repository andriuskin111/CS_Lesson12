using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PassControlBusinesLogicLayer;

namespace PassControl.test
{
    [TestClass]
    public class EventControllerTest
    {
        [TestMethod]
        public void TestTryPass()
        {
            // Arrange
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.Retrieve(1);
            EventController eventController = new EventController(employeeRepository);
            GateRepository gateRepository = new GateRepository();
            Gate gate = gateRepository.Retrieve(1);

            // Act
            bool hasRights = eventController.TryPass(employee.EmployeeId, gate.GateId);

            // Assert
            Assert.IsTrue(hasRights);
        }
    }
}
