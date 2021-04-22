using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationBL
{
    public class StaffMember : Person
    {
        public decimal MonthSalary { get; set; }
        public StaffMember( string name, decimal monthSalary, List<DayReport> dayReport ) : base(name, monthSalary, dayReport)
        {
            MonthSalary = monthSalary;
        }
    }
}
