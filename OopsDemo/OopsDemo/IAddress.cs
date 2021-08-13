using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    interface IAddress
    {
        string ShowAddress();
        string AdressLine1 { get; set; }
        string State { get; set; }
        string City { get; set; }
        string PinCode { get; set; }
    }
    public class Customer:IAddress
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string AdressLine1 { get; set; }
        public string State { get; set; }
        public string City { get ; set; }
        public string PinCode { get; set ; }

        public string ShowAddress()
        {
            //logic for prinitng the address
            return null;
        }
    }
}
