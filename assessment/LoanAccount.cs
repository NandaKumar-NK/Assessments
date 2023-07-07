using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class LoanAccount:Customer
    {
        private int LoanAccNo;
        private int LoanAmount;
        private int LoanTenureinyrs;

        public int LoanAccNo1 { get => LoanAccNo; set => LoanAccNo = value; }
        public int LoanAmount1 { get => LoanAmount; set => LoanAmount = value; }
        public int LoanTenureinyrs1 { get => LoanTenureinyrs; set => LoanTenureinyrs = value; }

        public  LoanAccount(int LoanAccNo,int LoanAmount,int LoanTenureinyrs,int CustId,string CustName,int CustPhone ):
            base(CustId,CustName,CustPhone)
        {
            this.LoanAccNo1 = LoanAccNo;
            this.LoanAmount1 = LoanAmount;
            this.LoanTenureinyrs1 = LoanTenureinyrs;
        }

        public   override void Display()
        {
            Console.WriteLine("Loan Account Details");
            Console.WriteLine("Loan Account No :" + LoanAccNo);
            Console.WriteLine("Loan Amount:" + LoanAmount);
            Console.WriteLine("Loan tenure in years:" + LoanTenureinyrs);
        }
    }
}
