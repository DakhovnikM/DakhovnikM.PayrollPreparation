using System;
using System.Collections.Generic;

using DakhovnikM.PayrollPreparation.PayrollPreparationBL;
using DakhovnikM.PayrollPreparation.PayrollPreparationRepository;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationConsole
{
    class Program
    {
        static void Main( string[] args )
        {
            Manager manager = new Manager("test", new List<DayReport>()
            {
                new DayReport(DateTime.Now.AddDays(-3)," test",8,"test message"),
                new DayReport(DateTime.Now.AddDays(-2)," test",9,"test message"),
                new DayReport(DateTime.Now.AddDays(-1)," test",7,"test message")
            });
            
            Console.WriteLine(manager.TotalPey);
        }
    }
}
