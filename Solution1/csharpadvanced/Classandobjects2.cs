//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharp_assignments
//{
//    class batsman
//    {
//        private int bcode, innings, notout, runs;
//        private String bname;
//        private float batavg;
//        private void calcavg()
//        {
//            this.batavg = this.runs / (this.innings - this.notout);
//        }
//        public void readData()
//        {
//            Console.WriteLine("enter the batsman name");
//            this.bname = Console.ReadLine();
//            Console.WriteLine("enter the batsman code");
//            this.bcode = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the innings");
//            this.innings = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the notout");
//            this.notout = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the runs");
//            this.runs = Convert.ToInt32(Console.ReadLine());

//            calcavg();
//        }
//        public void displayData()
//        {
//            Console.WriteLine("the batsman name is {0}", this.bname);
//            Console.WriteLine("the batsman code is {0}", this.bcode);

//            Console.WriteLine("the batsman innings is {0}", this.innings);
//            Console.WriteLine("the batsman notout is {0}", this.notout);
//            Console.WriteLine("the batsman average score is {0}", this.batavg);
//            Console.WriteLine("the batsman runs is {0}", this.runs);
//        }


//        static void Main(String[] args)
//        {
//            batsman b = new batsman();
//            b.readData();
//            b.displayData();
//        }
//    }
//}
