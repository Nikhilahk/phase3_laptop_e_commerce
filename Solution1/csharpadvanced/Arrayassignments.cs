//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharp_assignments
//{
//    class Arrayassignments
//    {
//        static void Main(String[] args)
//        {
//            firstprog();
//            secondprog();
//            thirdprog();
//            fourthprog();
//            fifthprog();
//            sixthprog();
//            seventhprog();
//            eigthprog();
//            ninethprog();
//            tenthprog();
//            eleventhprog();
//        }
//        public static void firstprog()
//        {

//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            for (int i = 9; i >= 0; i--)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//        public static void secondprog()
//        {
//            float sum = 0;
//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//                sum += a[i];
//            }
//            Console.WriteLine("the average of the array elements is {0}",(float)sum / 10);
//        }
//        public static void  thirdprog()
//        {

//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            int temp = a[a.Length-1];
//            a[a.Length - 1] = a[0];
//            a[0] = temp;
//            Console.WriteLine("the changed array is :");
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//        public static void fourthprog()
//        {

//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Array.Sort(a);
//            Console.WriteLine("the largest of array is {0}", a[a.Length - 1]);
//        }
//        public static void fifthprog()
//        {

//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Array.Sort(a);
//            Console.WriteLine("The smallest of the array is {0}", a[0]);
//        }
//        public static void sixthprog()
//        {

//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Array.Sort(a);
//            Console.WriteLine("the array in ascending order is :");
//           for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//        public static void seventhprog()
//        {

//            int[] a = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Enter the array input");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            int[] b = new int[10];
//            for (int i = 0; i < 10; i++)
//            {
//                b[i] = a[9 - i];
//            }
//            Console.WriteLine("the copied array elements are ");
//            for (int i = 0; i < 9; i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//        }
//        public static void eigthprog()
//        {
//            int[,] a= new int[4, 3];
//            Console.WriteLine("enter the array elements");
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    a[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write(a[i, j]+"     ");
//                }
//                Console.WriteLine();
//            }

//        } 
//        public static void ninethprog()
//        {
//            Console.WriteLine("enter the dimensions of the 2-D array");
//            int m = Convert.ToInt32(Console.ReadLine());
//            int n= Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the elements of first array");
//            int[,] a = new int[m, n];
//            int[,] b = new int[m, n];
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    a[i,j]= Convert.ToInt32(Console.ReadLine());
//                }

//            }
//            Console.WriteLine("enter the values of second array");
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    b[i, j] = Convert.ToInt32(Console.ReadLine());
//                    a[i, j] = a[i, j] + b[i, j];
//                }

//            }
//            Console.WriteLine("the array after addidtion is :");
//            for(int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(a[i, j]+"     ");
//                }
//                Console.WriteLine();
//            }

//        }
//        public static void tenthprog()
//        {
//            Console.WriteLine("enter the dimensions of first 2D array");
//            int m1 = Convert.ToInt32(Console.ReadLine());
//            int n1 = Convert.ToInt32(Console.ReadLine());
//            int m2 = Convert.ToInt32(Console.ReadLine());
//            int n2 = Convert.ToInt32(Console.ReadLine());
//            int[,] a = new int[m1, n1];
//            int[,] b = new int[m2, n2];
//            int[,] c = new int[m1, n2];
//            Console.WriteLine("enter the elements of first array");
//            for (int i = 0; i < m1; i++)
//            {
//                for (int j = 0;j < n1; j++)
//                {
//                    a[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            int s=0;
//            Console.WriteLine("enter the elements of second array");
//            for (int i = 0; i < m1; i++)
//            {
//                for (int j = 0; j < n1; j++)
//                {
//                    b[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            for (int i = 0; i < m1; i++)
//            {
//                for (int j = 0; j < n2; j++)
//                {
//                    for (int k = 0; k < n1; k++)
//                    {
//                        s = s + a[i, k] * b[k, j];
//                    }
//                    c[i, j] = s;
//                    s = 0;
//                }
//            }
//            Console.WriteLine("the multiplied matrix is ");
//            for (int i = 0; i < m1; i++)
//            {
//                for (int j = 0; j < n2; j++)
//                {
//                    Console.Write(c[i, j]+"  ");
//                }
//                Console.WriteLine();
//            }

//        }
//        public static void eleventhprog()
//        {
//            Console.WriteLine("input the size of 2D array");
//            int m = Convert.ToInt32(Console.ReadLine());
//            int n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("input the elements of the array ");
//            int[,] a = new int[m, n];
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    a[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.WriteLine("elements of the matrix are");
//            int s = 0;
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(a[i, j]);
//                    s += a[i, j];
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("sum of all elements is {0}", s);
//            Console.WriteLine("row wise summ is");
//            for (int i = 0; i < m; i++)
//            {
//                int rsum = 0;
//                for (int j = 0; j < n; j++)
//                {
//                    rsum += a[i, j];
//                }
//                Console.WriteLine(rsum);
//            }
//            Console.WriteLine("transpose of the matrix is : ");
//            for (int i = 0; i < m; i++)
//            {
                
//                for (int j = 0; j < n; j++)
//                {
//                    Console.Write(a[j, i]);
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("column sum is : ");
//            for (int i = 0; i < m; i++)
//            {
//                int csum=0;
//                for (int j = 0; j < n; j++)
//                {
//                    csum += a[j, i];
//                }
//                Console.WriteLine(csum);
//            }
//        }
//    }
//}

