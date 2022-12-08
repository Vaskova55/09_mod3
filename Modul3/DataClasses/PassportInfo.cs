using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3.DataClasses
{
    public class PassportInfoClass
    {
        public string SeriesNumber { get; set; } = default!;
        public string IssuingDepartment { get; set; } = default!;
        public DateTime Date { get; set; } = default!;
        public string DepartmentCode { get; set; } = default!;
        public RegistrationAddressClass RegistrationAddress { get; set; } = default!;
    }
}
