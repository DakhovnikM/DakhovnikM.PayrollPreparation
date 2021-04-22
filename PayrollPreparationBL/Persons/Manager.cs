using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationBL
{
    public class Manager : StaffMember
    {
        decimal peyPerHour;
        public decimal TotalPey { get; set; }

        private decimal BonusPerMonth => 20000;
        public Manager( string name, List<DayReport> dayReports ) : base(name, 200000, dayReports)
        {
            peyPerHour = MonthSalary / Settings.WorkingHoursPerMonth;
            //TotalPey = 0;
            var bonusPerDay = (BonusPerMonth / Settings.WorkingHoursPerMonth) * Settings.WorkingHoursPerDay;

            foreach (var dayReport in dayReports)
            {
                if (dayReport.Hours <= Settings.WorkingHoursPerDay)
                {
                    TotalPey += dayReport.Hours * peyPerHour;
                }
                else
                {
                    TotalPey += Settings.WorkingHoursPerDay * peyPerHour + bonusPerDay;
                }
            }
        }

        private void GetData()
        {

        }
    }
}
