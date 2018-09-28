using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Delegate6
    {
        public void Test(int i, int j)
        {
            Console.WriteLine("From Test(int i,int j) :" + i + "::" + j);

        }
        public void Test1(int i, int j)
        {
            Console.WriteLine("From Test1(int i,int j) :" + i + "::" + j);

        }
        public void Test2(int i, int j)
        {
            Console.WriteLine("From Test3(int i,int j) :" + i + "::" + j);

        }
        public void Test3(int i, int j)
        {
            Console.WriteLine("From Test4(int i,int j) :" + i + "::" + j);

        }
        public void Test4(int i, int j)
        {
            Console.WriteLine("From Test5(int i,int j) :" + i + "::" + j);

        }
        public void Test5(int i, int j)
        {
            Console.WriteLine("From Test6(int i,int j) :" + i + "::" + j);

        }
        static void Main(string[] args)
        {
            Delegate6 dl = new Delegate6();
            
            DelegateMethod6 dm = dl.Test;
            DelegateMethod6 dm1 = dl.Test1;
            DelegateMethod6 dm2 = dl.Test2;
            DelegateMethod6 dm3 = dl.Test3;
            DelegateMethod6 dm4 = dl.Test4;
            DelegateMethod6 dm5 = dl.Test5;
            DelegateMethod6 dm6 = dm + dm1 + dm2 + dm3 + dm4 + dm5 - dm1-dm3 + dm2;
            dm6(10, 20);
            Console.WriteLine("---------------End of the Program---------------");
        }
    }
}
