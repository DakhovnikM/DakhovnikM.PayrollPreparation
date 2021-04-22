using System;
using System.Collections.Generic;
using System.Linq;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationBL
{
    public class Person
    {
        public string Name { get; set; }

        //public byte NormalHours { get; }
        //public byte RecyclingHours { get; }
        //public decimal PayPerHour { get; set; }
        //public int HoursForPeriod { get; set; }
        //public decimal TotalPay { get; set; }
        //public decimal BonusPay { get; set; }

        public decimal Salary { get; set; }
        public List<DayReport> DayReports { get; set; }

        public Person( string name, decimal salary, List<DayReport> dayReports )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Salary = salary;
            DayReports = dayReports;
            //HoursForPeriod = dayReport.Sum(x => x.NormalHours + x.RecyclingHours);
            //PayPerHour = (salary / Settings.WorkingHoursPerMonth) / Settings.WorkingHoursPerDay;
        }

    }
}
