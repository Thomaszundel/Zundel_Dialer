using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Dialer
{
    class CellPhone : Phone
    {
        public CellPhone(string phoneNumber, string companyName, string phoneType) : base(phoneNumber, companyName, phoneType)
        {

        }
        public override string Dial()
        {
            string phoneNumberToDial = "1+" + PhoneNumber;
            string dialPhone = CompanyName + " is being dialed using " + phoneNumberToDial + "...";
            return dialPhone;
        }

    }
}
