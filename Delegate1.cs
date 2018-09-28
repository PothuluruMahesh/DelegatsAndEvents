using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//calling the methods by using delagats
namespace DelegatesAndEvents
{
    
    class Delegate1
    {
        public delegate void DelegateMethod1();
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
            DelegateMethod1 dm = new DelegateMethod1(dl.Test);//first way to call the method by using delegates
            dm();
            DelegateMethod1 dm1 = new DelegateMethod1(dl.Test1);
            dm1();
        }
    }
}
