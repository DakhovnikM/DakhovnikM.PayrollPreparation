using System.Collections.Generic;
using System;

using NUnit.Framework;
using DakhovnikM.PayrollPreparation.PayrollPreparationBL;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationTest
{
    public class PersonsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ManagerTotalPay()
        {
            Manager manager = new Manager("test", new List<DayReport>()
            {
                new DayReport(DateTime.Now.AddDays(-3)," test",8,"test message"),
                new DayReport(DateTime.Now.AddDays(-2)," test",9,"test message"),
                new DayReport(DateTime.Now.AddDays(-1)," test",7,"test message")
            });

            Assert.IsTrue(manager.TotalPey == 29750);
        }
    }
}