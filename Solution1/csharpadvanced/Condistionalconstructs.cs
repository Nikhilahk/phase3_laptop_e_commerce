//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharpassignments
//{
//    class Condistionalconstructs
//    {
//        static void Main(String[] args)
//        {
//            //Condistionalconstructs.firstprog();
//            //Condistionalconstructs.secondprog();
//            //Condistionalconstructs.thirdprog();
//            //Condistionalconstructs.fourthprog();
//            // Condistionalconstructs.fifthprog();
//            // Condistionalconstructs.sixthprog();
//            // Condistionalconstructs.seventhprog();
//            // Condistionalconstructs.eigthprog();
//            // Condistionalconstructs.ninethprog();
//            Condistionalconstructs.tenthprog();


//        }
//        public static void firstprog()
//        {

//            Console.WriteLine("Enter the integer");
//            int a = Convert.ToInt32(Console.ReadLine());
//            if (a % 2 == 0)
//                Console.WriteLine("Number is even");
//            else
//                Console.WriteLine("Number is odd");
//        }
//        public static void secondprog()
//        {

//            Console.WriteLine("Enter the integer");
//            int a = Convert.ToInt32(Console.ReadLine());
//            if (a < 0)
//                a = -a;
//            Console.WriteLine("Absolute valur of a is {0}", a);
//        }
//        public static void thirdprog()
//        {

//            Console.WriteLine("Enter the quantity");
//            int q = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter the price per item");
//            int p = Convert.ToInt32(Console.ReadLine());
//            int a = p * q;
//            if (a > 5000)
//            {
//                Console.WriteLine("The amount is {0}", (double)(0.9 * a));
//            }
//            else
//                Console.WriteLine("The amount is {0}", a);
//        }
//        public static void fourthprog()
//        {

//            Console.WriteLine("Enter the selling price");
//            int sp = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter the costprice");
//            int cp = Convert.ToInt32(Console.ReadLine());
//            if (cp > sp)
//            {
//                Console.WriteLine("The loss incurred is {0}", (cp - sp));
//            }
//            else
//                Console.WriteLine("the profit incurred is {0}", (sp - cp));
//        }
//        public static void fifthprog()
//        {
//            Console.WriteLine("enter age of ram :");
//            int ram = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter age of sulabh :");
//            int sulabh = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter age of ajay :");
//            int ajay = Convert.ToInt32(Console.ReadLine());
//            if (ajay < sulabh)
//            {
//                if (ajay < ram)
//                {
//                    Console.WriteLine("Ajay is youngest");
//                }
//                else
//                {
//                    Console.WriteLine("Ram is youngest");
//                }
//            }
//            else
//            {
//                if (sulabh < ram)
//                {
//                    Console.WriteLine("Sulabh is youngest");
//                }
//                else
//                {
//                    Console.WriteLine("ram is youngest");
//                }
//            }
//        }
//            public static void sixthprog()
//            {
//            Console.WriteLine("Enter the three angles of the triangle : ");
//            int a = Convert.ToInt32(Console.ReadLine());
//            int b = Convert.ToInt32(Console.ReadLine());
//            int c = Convert.ToInt32(Console.ReadLine());
//            if (a + b + c == 180)
//            {
//                Console.WriteLine("Triangle is valid");
//            }
//            else
//            {
//                Console.WriteLine("triangle is not valid");
//            }
//        }
//        public static void seventhprog()
//        {
//            Console.WriteLine("input the year :");
//            int y = Convert.ToInt32(Console.ReadLine());
//            if (y % 400 == 0)
//            {
//                Console.WriteLine("entered year is leap year");
//            }
//            else
//            {
//                if (y % 4 == 0 && y % 100 != 0)
//                    Console.WriteLine("entered year is leap year");
//                else
//                    Console.WriteLine("Entered year is not a leap year");
//            }
//        }
//        public static void eigthprog()
//        {
//            Console.WriteLine("Enther the basic salary of employee :");
//            float bs = Convert.ToInt32(Console.ReadLine());
//            float hra, da;
//            if (bs < 1500)
//            {
//                hra =(float) 0.1 * bs;
//                da = (float)0.9 * bs;
//            }
//            else
//            {
//                hra = 500;
//                da =(float) 0.98 * bs;
//            }
//            Console.WriteLine("the gross salary of employee is {0}", (bs + hra + da));
//        }
//        public static void ninethprog()
//        {
//            Console.WriteLine("Enter the percentage fo student: ");
//            int k = Convert.ToInt32(Console.ReadLine());
//            if (k >= 60)
//                Console.WriteLine("student passed in first class");
//            else if(k>=50 && k < 60)
//                Console.WriteLine("student passed in second class");
//            else if (k>=40 && k<50)
//                Console.WriteLine("student passed in third class");
//            else
//                Console.WriteLine("student has failed");
//        }
//        public static void tenthprog()
//        {
//            Console.WriteLine("if the quadratic equation is ax2+bx+c=0\n Enter the values of a,b,c");
//            float a = Convert.ToInt32(Console.ReadLine());
//            float b= Convert.ToInt32(Console.ReadLine());
//            float c= Convert.ToInt32(Console.ReadLine());
//            float r1 =(float)( -b + Math.Sqrt((b * b - 4 * a * c))/2*a);
//            float r2 = (float)(-b - Math.Sqrt((b * b - 4 * a * c)) / 2 * a);
//            Console.WriteLine("th roots of the equation are {0} and {1}", r1, r2);
//        }

//    }
//    }

