using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakhovnikM.PayrollPreparation.PayrollPreparationBL
{
    class Freelancer : Person
    {
        public Freelancer( string name, List<DayReport> dayReport ) : base(name, 0, dayReport)
        {
        }
    }
}
