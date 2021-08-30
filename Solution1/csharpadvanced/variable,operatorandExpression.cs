//using System;

//namespace csharpassignments
//{
//    class Program
//    {
//        static void Main(string[] args)
//    {
//        Program.firstprog();
//        Program.helloworld();
//        Program.thirdprog();
//        Program.fourthprog();
//        Program.fifthprog();
//        Program.sixthprog();
//        Program.seventhprog();
//        Program.eighthprog();
//        Program.ninthprog();
//        Program.tenthprog();
//    }
//    public static void firstprog()
//    {
//        Console.WriteLine("Subject      Marks\nMathematics      97\nComputer        77\nChemistry       69");

//    }
//    public static void helloworld()
//    {
//        Console.WriteLine("Hello World");
//    }
//    public static void thirdprog()
//    {
//            Console.WriteLine("Enter the two integers");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Sum is : " + (a + b));
//    }
//    public static void fourthprog()
//    {
//        Console.WriteLine("Enter intrest :");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter principle :");
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter rate :");
//        int c = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Simple intrest is: " + (double)((a * b * c) / 100));

//    }
//    public static void fifthprog()
//    {
//        Console.WriteLine("Enter the number");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("The entered number is {0}", (a % 2 == 0 ? "Even" : "odd"));
//    }
//    public static void sixthprog()
//    {
//        Console.WriteLine("Enter the number");

//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("the entered number is {0}", (a > 0 ? "Positive" : "Negetive"));
//    }
//    public static void seventhprog()
//    {

//        Console.WriteLine("Enter the numbers");

//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        a = a + b;
//        b = a - b;
//        a = a - b;
//        Console.WriteLine("numbers after swaps a is {0} b is {1} ", a, b);
//    }
//    public static void eighthprog()
//    {

//        Console.WriteLine("Enter the numbers");

//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        int c = a;
//        a = b;
//        b = c;

//        Console.WriteLine("numbers after swaps a is {0} b is {1} ", a, b);
//    }
//    public static void ninthprog()
//    {
//        Console.WriteLine("Enter the number of days");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int l = a;
//        int k = (a >= 365 ? a / 365 : 0);
//        a = a - k * 365;
//        int m = (a >= 30 ? a / 30 : 0);
//        int d = l - 365 * k - m * 30;
//        Console.WriteLine("time period is : {0} years {1} months {2} days", k, m, d);
//    }
//    public static void tenthprog()
//    {
//        Console.WriteLine("Enter the integer");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int k = a;
//        int fifh = ((a >= 500) ? a / 500 : 0);
//        a = a - 500 * fifh;
//        int hun = ((a >= 100) ? a / 100 : 0);
//        a = a - 100 * hun;
//        int fif = ((a >= 50) ? a / 50 : 0);
//        a = a - 50 * fif;
//        int twen = ((a >= 20) ? a / 20 : 0);
//        a = a - 20 * twen;
//        int ten = ((a >= 10) ? a / 10 : 0);
//        Console.WriteLine("{0} number of 500 notes ,{1} number of 100 notes, {2} number of 50 notes , {3} number of 20 notes ,{4} number of 10 notes", fifh, hun, fif, twen, ten);
//    }

//}
//    }
