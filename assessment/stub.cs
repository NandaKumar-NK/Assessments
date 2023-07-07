using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assessment
{
    class stub
    {
        public void coordiante(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The Coordinate point (" + x + "," + y + ") lies in the First quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The Coordinate point (" + x + "," + y + ") lies in the Second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The Coordinate point (" + x + "," + y + ") lies in the Third quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The Coordinate point (" + x + "," + y + ") lies in the Fourth quadrant");
            }
            else if (y == 0 && x == 0)
            {
                Console.WriteLine("points in origin");
            }
            else
            {
                Console.WriteLine("Enter only numbers");
            }
        }


        public void marks(int phy, int chem, int cs)
        {
            int percentage;
            percentage = (phy + chem + cs) / 3;
            Console.WriteLine("Total Marks " + (phy + chem + cs));
            Console.WriteLine("Percentage = " + percentage);
            if (percentage < 100 && percentage >= 80)
            {
                Console.WriteLine("Division = First");
            }
            else if (percentage < 80 && percentage >= 60)
            {
                Console.WriteLine("Division = Second");

            }
            else if (percentage < 60 && percentage >= 35)
            {
                Console.WriteLine("Division = Third");
            }
            else
            {
                Console.WriteLine("Division = Forth");
            }

        }
        public void ElectricityBill(int unit)
        {
            int minCharge = 100;
            double charge, total;
            if (unit < 200)
            {
                charge = Convert.ToDouble(unit * 1.20);
                if (charge > 400)
                {
                    total = charge + (charge * 0.15);
                    Console.WriteLine("Electricity charge is" + total);
                }
                else if (charge < 100)
                {
                    Console.WriteLine("Electricity charge is" + minCharge);
                }
                Console.WriteLine("Electricity charge is" + charge);


            }
            else if (unit < 400 && unit >= 200)
            {
                charge = Convert.ToDouble(unit * 1.50);
                if (charge > 400)
                {
                    total = charge + (charge * 0.15);
                    Console.WriteLine("Electricity charge is" + total);
                }
                else if (charge < 100)
                {
                    Console.WriteLine("Electricity charge is" + minCharge);
                }

                Console.WriteLine("Electricity charge is" + charge);


            }
            else if (unit < 600 && unit >= 400)
            {
                charge = Convert.ToDouble(unit * 1.80);
                if (charge > 400)
                {
                    total = charge + (charge * 0.15);
                    Console.WriteLine("Electricity charge is" + total);
                }
                else if (charge < 100)
                {
                    Console.WriteLine("Electricity charge is" + minCharge);
                }
                Console.WriteLine("Electricity charge is " + charge);

            }
            else if (unit > 600)
            {
                charge = Convert.ToDouble(unit * 2.00);
                if (charge > 400)
                {
                    total = charge + (charge * 0.15);
                    Console.WriteLine("Electricity charge is" + total);
                }
                else if (charge < 100)
                {
                    Console.WriteLine("Electricity charge is" + minCharge);
                }
                Console.WriteLine("Electricity charge is" + charge);
            }

        }

    }


    //public void pattern(int row)
    //{
    //    int count = 1;
    //    for (int i = 0; i < row; i++)
    //    {
    //        for (int j = 0; j <= i; j++)
    //        {
    //            Console.Write(count + " ");
    //            count++;
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //public void Pattern1(int rows)
    //{
    //    int count = 0;
    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 1; j <= rows - i; j++)
    //            Console.Write(" ");
    //        for (int j = 1; j <= 2 * i - 1; j++)
    //            Console.Write(count);
    //        count++;
    //        Console.WriteLine("");
    //    }

    //}



}