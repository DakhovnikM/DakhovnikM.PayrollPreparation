using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationBL
{
    class Emploee : StaffMember
    {
        public Emploee( string name, List<DayReport> dayReports ) : base(name, 120000, dayReports)
        {
        }
    }
}
