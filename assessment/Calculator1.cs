using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    partial class Calculator
    {


        private int num1, num2;
        private double answer;
        public Calculator(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;

        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public double Answer { get => answer; set => answer = value; }
    }
}
