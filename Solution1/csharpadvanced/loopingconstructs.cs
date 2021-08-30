//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharp_assignments
//{
//    class loopingconstructs
//    {

//        static void Main(String[] args)
//        {
//            //loopingconstructs.firstprog();
//            //loopingconstructs.secondprog();
//            // loopingconstructs.thirdprog();
//            // loopingconstructs.fourthprog();
//            // loopingconstructs.fifthprog();
//            //  loopingconstructs.sixthprog();
//            //loopingconstructs.seventhprog();
//            //  loopingconstructs.eigthprog();
//            // loopingconstructs.ninethprog();
//            loopingconstructs.tenthprog();

//        }
//        public static void firstprog()
//        {

//            for (int i = 1; i < 11; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//        public static void secondprog()
//        {
//            int s = 0;
//            for (int i = 1; i < 11; i++)
//            {
//                s += i;
//            }
//            Console.WriteLine(s);
//        }
//        public static void thirdprog()
//        {
//            Console.WriteLine("Enter the number whose factorial need to be finded");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int fact = 1;
//            for (int i = n; i > 1; i--)
//            {
//                fact *= i;
//            }
//            Console.WriteLine("factorial of number is : " + fact);
//        }
//        public static void fourthprog()
//        {
//            Console.WriteLine("enter the two numbers");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int m = Convert.ToInt32(Console.ReadLine());
//            int k = 1;
//            for (int i = 0; i < m; i++)
//            {
//                k *= n;
//            }
//            Console.WriteLine("the result is : "+k);
//        }
//        public static void fifthprog()
//        {
//            Console.WriteLine("Enter the integer to be reversed");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int k = 0;
//            while (n >= 1)
//            {
//                int a = n % 10;
//                k=k*10+a;
//                n = n / 10;
//            }
//            Console.WriteLine("reversed integer is "+k);
//        }
//        public static void sixthprog()
//        {
//            Console.WriteLine("Enter the integer whose sum of digits to be found");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int s = 0;
//            while (n > 0)
//            {
//                int a = n % 10;
//                s += a;
//                n = n / 10;
//            }
//            Console.WriteLine("Sumof all the digits :" + s);
//        }
//        public static void seventhprog()
//        {
//            Console.WriteLine("Enter the number to check for palindrome : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int l = n;
//            int k = 0;
//            while (n >= 1)
//            {
//                int a = n % 10;
//                k = k * 10 + a;
//                n = n / 10;
//            }
//            if (k == l)
//                Console.WriteLine("The entered number is a palandrome");
//            else
//                Console.WriteLine("Entered number is not a palendorme");
//        }
//        public static void eigthprog()
//        {
//            Console.WriteLine("Enter the number to check for prime number");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int i = 2;

//            while (i < n)
//            {
//                if(n%i==0)
//                {
//                    Console.WriteLine("entered number is not prime");
//                    break;
//                }
//                i += 1;

//            }
//            if(i==n)
//                Console.WriteLine("entered number is prime");

//        }
//        public static void ninethprog()
//        {
//            int psum = 0, nsum = 0, zsum = 0;
//            String m;
//            do
//            {
//                Console.WriteLine("Enter the number");
//                int n = Convert.ToInt32(Console.ReadLine());
//                if (n > 0)
//                    psum += 1;
//                if (n < 0)
//                    nsum += 1;
//                if (n == 0)
//                    zsum += 1;
//                Console.WriteLine("Do the user want to continue entering the numbers? Y/N");
//                m = Console.ReadLine();
//            } while (m == "Y");
//            Console.WriteLine("The number of positive numbers are {0} , negetive numbers are {1} , zeros are {2}",psum, nsum, zsum);
//        }
//        public static void tenthprog()
//        {
//           bool b=false;
//            Console.WriteLine("Enter the number");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int min = n, max = n;
//            do
//            {
//                Console.WriteLine("Do the user want to continue enter Y/N");
//                String s = Console.ReadLine();
//                if (s == "Y")
//                {

//                    Console.WriteLine("Enter the number");
//                    b= true;
//                    n = Convert.ToInt32(Console.ReadLine());
//                    if (min > n)
//                        min = n;
//                    if (max < n)
//                        max = n;
//                }
//                else
//                {
//                    b = false;
//                }
//            }
//            while (b == true);
//            Console.WriteLine("the minimun number is {0} and maximum number is {1}", min, max);
//        }

//    }
//}
