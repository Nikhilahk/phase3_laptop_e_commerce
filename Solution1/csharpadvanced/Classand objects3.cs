//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharp_assignments
//{

//    class Test
//    {
//        private int Nocandidate, TestCode, CentreReqd;
//        private String Description;
//        private int calcntr()
//        {
//            return (this.Nocandidate / 100) + 1;
            
//        }
//        public void schedule()
//        {
//            Console.WriteLine("enter the TestCode:");
//            this.TestCode = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the description :");
//            this.Description =Console.ReadLine();
//            Console.WriteLine("enter the No candidate:");
//            this.Nocandidate = Convert.ToInt32(Console.ReadLine());
//           this.CentreReqd=calcntr();

//        }
//        public void disptest()
//        {
//            Console.WriteLine("the testcode is : {0}",this.TestCode);

//            Console.WriteLine("the number of candidates is : {0}", this.Nocandidate);
//            Console.WriteLine("the Description is : {0}", this.Description);
//            Console.WriteLine("the centres required is : {0}", this.CentreReqd);
//        }
//        static void Main(String[] args)
//        {
//            Test t = new Test();
//            t.schedule();
//            t.disptest();
//        }
//    }
//}
