﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PassControlBusinesLogicLayer;

namespace PassControl.test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestHasRights()
        {
            // Arrange
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.Retrieve(1);

            // Act
            bool expected = employee.HasRights(1);

            // Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestGetTotalHours()
        {
            // Arrange
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.Retrieve(1);
            employee.PassTrueEvents.Add(new PassTrueEvent(new DateTime(2020 - 01 - 01)));
            employee.PassTrueEvents.Add(new PassTrueEvent(new DateTime(2020 - 01 - 01)));

            double expected = 0;

            // Act
            double actual = employee.GetTotalHours();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
