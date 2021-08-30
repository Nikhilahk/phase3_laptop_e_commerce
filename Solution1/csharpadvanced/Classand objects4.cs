//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace csharp_assignments
//{
//    class Class4
//    {
//        private int Flightnumber;
//        private float distance, fuel;
//        private String destination;
//        private void calfuel()
//        {
//            if (this.distance <= 1000)
//                this.fuel = 500;
//            else if (this.distance > 1000 && this.distance <= 2000)
//                this.fuel = 1100;
//            else if (this.distance > 2000)
//                this.fuel = 2200;
//        }
//        public void feedinfo()
//        {
//            Console.WriteLine("enter the flight destination");
//            this.destination = Console.ReadLine();
//            Console.WriteLine("enter the flight number");
//            this.Flightnumber = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the distance");
//            this.distance = Convert.ToInt32(Console.ReadLine());
//            calfuel();
//        }
//        public void showinfo()
//        {
//            Console.WriteLine("the flight number is {0} ", this.Flightnumber);
//            Console.WriteLine("the flight distance is {0} ", this.distance);
//            Console.WriteLine("the flight fuel is {0} ", this.fuel);
//            Console.WriteLine("the flight destination is {0} ", this.destination);


//        }
//        static void Main(String[] args)
//        {
//            Class4 c = new Class4();
//            c.feedinfo();
//            c.showinfo();
//        }
//    }
//}
