using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelegateMethod2();
    class Delegate2
    {
        public void Test()
        {
            Console.WriteLine("From Test()");
        }
        public void Test1()
        {
            Console.WriteLine("From Test1()");
        }
        static void Main(string[] args)
        {
            Delegate1 dl = new Delegate1();
            DelegateMethod2 dm = dl.Test;//Second way to call the method by using delegates
            dm.Invoke();
            DelegateMethod2 dm1 = dl.Test1;
            dm1();
        }
    }
}
