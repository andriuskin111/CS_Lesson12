using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PassControlBusinesLogicLayer;

namespace PassControl.test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestRetrieveEmployeeId()
        {
            // Arrange
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.Retrieve(1);
            string expected = "Tom";

            // Act
            string actual = employee.EmployeeName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRetrieve()
        {
            // Arrange
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employeeList = employeeRepository.Retrieve();
            int expected = 10;

            // Act
            int actual = employeeList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
