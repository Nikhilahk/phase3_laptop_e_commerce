using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignments
{
    class Class5
    {
        private int adno;
        private String name;
        private float[] marks;
        private float average;
        private void getavg()
        {
            float s = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                s += marks[i];
            }
            this.average = s / marks.Length;

        }
        public void readinfo()
        {
            Console.WriteLine("enter the adno");
            this.adno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            this.name = Console.ReadLine();
            Console.WriteLine("enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] a = new float[n];
            Console.WriteLine("enter the values of marks array");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            marks = a;
            getavg();

        }
        public void showinfo()
        {
            Console.WriteLine("the adno is : {0}", this.adno);
            Console.WriteLine("the name is : {0}", this.name);
            Console.WriteLine("the vales of marks are");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("the average of marks is : {0} ", this.average);
        }
        static void Main(String[] args)
        {
            Class5 c = new Class5();
            c.readinfo();
            c.showinfo();
        }
    }
}
