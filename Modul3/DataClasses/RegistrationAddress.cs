using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3.DataClasses
{
    public class RegistrationAddressClass
    {
        public string Country { get; set; } = default!;
        public string Region { get; set; } = default!;
        public string City { get; set; } = default!;
        public string AddressPart { get; set; } = default!;
    }
}
