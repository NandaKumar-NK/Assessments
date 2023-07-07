using assessment;
using Assessment;
using System.Xml.Linq;

class program
{
    public static void Main(string[] args)
    {
        FileHandling fileHandling = new FileHandling();
        fileHandling.CreateFile();
        fileHandling.Readfile();

    }

    //   SmartPhone ph = new SmartPhone();
    //    double balance = 1;

    //            if (balance <= 0)
    //            {
    //                try
    //                {
    //                    Console.WriteLine("Not enough balance");
    //                }
    //                catch (NotFiniteNumberException ex)
    //                {
    //    Console.WriteLine(ex.Message);
    //}
    //            }
    //            else
    //{
    //    ph.CallLog();
    //}
}
    //public static void Main(string[] args)
    //{
    //    int option, num1, num2;
    //    Console.WriteLine("1.Add 2.Subtract 3.Multiple 4.Division 5.modular");
    //    option=Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter number 1 value:");
    //    num1= Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter number 2 value:");
    //    num2 = Convert.ToInt32(Console.ReadLine());

    //    Calculator calc = new Calculator( num1, num2);
    //    switch (option)
    //    {
    //        case 1:
    //            calc.Add();
    //            break;
    //        case 2: 
    //            calc.Sub(); 
    //            break;
    //        case 3:
    //            calc.multiple();
    //            break;
    //        case 4:
    //            calc.divide();
    //            break;
    //        case 5:
    //            calc.modular();
    //            break;
    //        default:
    //            Console.WriteLine("Invalid option");
    //            break;



    //    }
    //    Console.WriteLine(calc.Answer);









        //int choice,rows;
        //Console.WriteLine("Choose 1 for Character Pattern 2 for Number Pattern:");
        //choice = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter a rows limit: ");
        //rows= Convert.ToInt32(Console.ReadLine());
        //if(choice == 1)
        //{
        //    StarPattern starpattern = new StarPattern(rows);
        //}
        //else if (choice == 2)
        //{
        //    NumPattern numpattern = new NumPattern(rows);
        //}








        //int n;
        //Console.WriteLine("Enter a array size:");
        //n=Convert.ToInt32(Console.ReadLine());

        //ArrayFunctions arrayFunctions= new ArrayFunctions(n);
        //arrayFunctions.ArraySort();


        //int AccNo, amount, IFSC, custid, phone,tensureYear;
        //string Breanch, name, AccountType;



        //Console.WriteLine("Enter Customer Name:");
        //name = Console.ReadLine();
        //Console.WriteLine("Enter Customer Id:");
        //custid = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Account Number:");
        // AccNo=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Tensure Year:");
        // tensureYear=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Amount:");
        //amount = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter IFSC Code:");
        //IFSC = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter phone Number:");
        //phone = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Breach Name:");
        //Breanch = Console.ReadLine();

        //LoanAccount la = new LoanAccount(AccNo, amount, tensureYear, custid, name, phone);

        //SavingsAccounts savingsAccounts = new SavingsAccounts(AccNo, amount, Breanch, IFSC, custid, name, phone);

        //Console.WriteLine("Enter Account Type(Loan / Savings):");
        //AccountType = Console.ReadLine();

        //if (AccountType == "Loan")
        //{
        //    la.Display();

        //}
        //else if (AccountType == "Savings")
        //{
        //    savingsAccounts.Display();
        //}
        //else
        //{
        //    Console.WriteLine("Enter a valid Account type!!");
        //}


        //savingsAccounts.Display();




        //Customer customer = new Customer(1,"abi",9500090914);
        // customer.Display();
        //CountLegs countLegs= new CountLegs(2,3,5);
        //Console.WriteLine("Total animals legs:");
        //Console.WriteLine(countLegs.Animals(2,3,5));

        //stub stub= new stub();
        //int X, Y;
        //Console.WriteLine("The value for X coordinate:");
        //X=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("The value for Y coordinate:");
        //Y =Convert.ToInt32(Console.ReadLine());
        //coordinates.coordiante(X,Y);


        //int RollNo, Physics, Chemistry, ComputerApplication;
        //string student_name;
        //Console.WriteLine("Input the Roll Number of the student: ");
        //RollNo=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Input the Name of the Student :");
        //student_name = Console.ReadLine();
        //Console.WriteLine(" Input the marks of Physics, Chemistry and Computer Application:");
        //Physics= Convert.ToInt32(Console.ReadLine());
        //Chemistry= Convert.ToInt32(Console.ReadLine());
        //ComputerApplication= Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Roll No : " + RollNo);
        //Console.WriteLine("Name of Student : " + student_name);
        //Console.WriteLine("Marks in Physics : " + Physics);
        //Console.WriteLine("Marks in Chemistry : " + Chemistry);
        //Console.WriteLine("Marks in Computer Application :  " + ComputerApplication);
        //coordinates.marks(Physics,Chemistry,ComputerApplication);

        //int cust_id, unit_consumed;
        //string Name;
        //Console.WriteLine("Input the Customer Id: ");
        //cust_id = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Input the Name of the customer :");
        //Name = Console.ReadLine();
        //Console.WriteLine("Enter the unit consumed by the user :");
        //unit_consumed = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Customer Id:" + cust_id);
        //Console.WriteLine("Customer Name:" + Name);
        //Console.WriteLine("Consumed Units:" + unit_consumed);

        //coordinates.ElectricityBill(unit_consumed);

        //int rows;
        //Console.WriteLine("Enter a row value:");
        //rows = Convert.ToInt32(Console.ReadLine());
        //Patternprog patternprog= new Patternprog(rows);

        //patternprog.pattern1(rows);

        //int i = 0, n = 0;
        //Console.Write("Input the number of elements to store in the array :");
        //n = Convert.ToInt32(Console.ReadLine());
        //singleArray.Array(i, n);

        //SingleArray singleArray= new SingleArray();


        //Console.WriteLine("Enter a number of rows:");
        //int rows=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter a number of column:");
        //int col = Convert.ToInt32(Console.ReadLine());
        //TransposeMatrix transposeMatrix = new TransposeMatrix( );

        //transposeMatrix.matrix(rows,col);
        //string psw;
        //Console.WriteLine("Enter a String : ");
        //psw= Console.ReadLine();
        //StringCount stringCount=new StringCount(psw);

        //int element;
        //Console.WriteLine("enter a array Length:");
        //element=Convert.ToInt32(Console.ReadLine());
        //PrimenumberSum primenumberSum= new PrimenumberSum();
        //primenumberSum.primenumber(element);

        //int npalindrom;
        //string spalindrom;
        //Console.WriteLine("Enter a number to check a palindrom or not:");
        //npalindrom=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter a String to check a palindrom or not:");
        //spalindrom=Console.ReadLine();
        //Palindrom palindrom = new Palindrom();

        //palindrom.StringPalindrom(spalindrom);
        //palindrom.NumberPalindrom(npalindrom);


    
