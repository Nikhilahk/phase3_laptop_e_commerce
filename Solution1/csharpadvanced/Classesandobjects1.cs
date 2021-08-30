//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharp_assignments
//{
//    public class Student
//    {
//        private int admno;
//        private String sname;
//        private float eng, math, science, total;
//        private float ctotal()
//        {
//            return this.eng + this.math + this.science;
             
//        }
//        public void takeData()
//        {
//            Console.WriteLine("enter admission number :");
//            this.admno = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("enter sname :");
//            this.sname = Console.ReadLine();
//            Console.WriteLine("enter english marks :");
//            this.eng = Convert.ToSingle(Console.ReadLine());

//            Console.WriteLine("enter math marks :");
//            this.math = Convert.ToSingle(Console.ReadLine());
//            Console.WriteLine("enter science marks :");
//            this.science = Convert.ToSingle(Console.ReadLine());
//            this.total = ctotal();

//        }
//        public void showData()
//        {
//            Console.WriteLine("the admission number is {0}", this.admno);
//            Console.WriteLine("the student name is {0}", this.sname);
//            Console.WriteLine("the english score is {0}", this.eng);
//            Console.WriteLine("the science score is {0}", this.science);
//            Console.WriteLine("the math score is {0}", this.math);
//            Console.WriteLine("the total score is {0}", this.total);
//        }
//        public static void Main(String[] args)
//        {
//            Student s = new Student();
//            s.takeData();

//            s.showData();

//        }
//    }
//}
