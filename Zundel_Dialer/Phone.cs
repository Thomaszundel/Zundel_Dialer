using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Dialer
{
    class Phone
    {
        private string _phoneNumber;
        private string _companyName;
        private string _phoneType;

        public Phone(string companyName, string phoneNumber, string phoneType)
        {
            _companyName = companyName;
            _phoneNumber = phoneNumber;
            _phoneType = phoneType;

        }
        public virtual string Dial()
        {
            
            string dialPhone = CompanyName + " is being dialed using " + PhoneNumber+"...";
            return dialPhone;
            
        }
        

        public string PhoneNumber
        {
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(_phoneNumber);
                sb.Replace(" ", "");
                sb.Insert(sb.ToString().IndexOf(")") + 1, " ");
                return sb.ToString();
            }
            set
            {
                //_phoneNumber = value;
            }
        }
        public string CompanyName
        {
            get { return _companyName; }
            //set { _companyName = value; }
        }

        public string PhoneType
        {
            get { return _phoneType; }
            //set { _phoneType = value; }
        }



    }
}
