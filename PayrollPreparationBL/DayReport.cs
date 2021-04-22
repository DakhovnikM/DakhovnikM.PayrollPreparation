using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationBL
{
    public class DayReport
    {
        public string Name { get; }
        public DateTime Date { get; }
        public byte Hours { get; }
        public int TotalHours { get; set; }
        public string Message { get; }

        public DayReport( DateTime date, string name, byte hoursPerDay, string message )
        {
            Date = date;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Hours = hoursPerDay;
            //TotalHours = hoursPerDay + recyclingHours;
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }


    }
}
