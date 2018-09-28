using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelegateMethod7(int i, int j);//onthere way of calling methods by using one delegate. this is called multicast delegate.
    class Delegate7
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
            Console.WriteLine("From Test1(int i,int j) :" + i + "::" + j);

        }
        public void Test4(int i, int j)
        {
            Console.WriteLine("From Test3(int i,int j) :" + i + "::" + j);

        }
        static void Main(string[] args)
        {
            Delegate7 dl = new Delegate7();

            /* dl.Test(10,20);
             * dl.Test1(10, 20);
             * dl.Test2(10, 20);
             * dl.Test3(10, 20);
             * dl.Test4(10, 20);
             * dl.Test5(10, 20); 
             */
            DelegateMethod7 dm = new DelegateMethod7(dl.Test);
            dm += dl.Test1;
            dm += dl.Test2;
            dm += dl.Test3;
            dm += dl.Test4;
            dm(10, 20);
            Console.WriteLine("---------------End of the Program---------------");
        }
    }
}
