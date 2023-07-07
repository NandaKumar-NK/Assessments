using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class Customer
    {
        private int CustId;
        private string CustName;
        private double CustPhone;
        public Customer(int Custid,string CustName ,double CustPhone)
        {
            this.CustId = Custid;
            this.CustName = CustName;
            this.CustPhone = CustPhone;
        }

        public int CustId1 { get => CustId; set => CustId = value; }
        public string CustName1 { get => CustName; set => CustName = value; }
        public double CustPhone1 { get => CustPhone; set => CustPhone = value; }

        public virtual void Display()
        {
            Console.WriteLine("Customer Id:" + CustId);
            Console.WriteLine("Customer Name:"+CustName);
            Console.WriteLine("Customer Phone No:" + CustPhone);
        }
    }
}
