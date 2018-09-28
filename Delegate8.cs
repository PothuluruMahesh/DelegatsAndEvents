using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int DelegateMethod8();// any functions having return type it is not suitable for the type of methods
    //bexoz it will give last return value only.
    class Delegate8
    {
        
        public int Test()
        {
            Console.WriteLine("From Test()");
            return 300;
        }
        public int Test1()
        {
            Console.WriteLine("From Test1()");
            return 600;
        }
        public int Test2()
        {
            Console.WriteLine("From Test2()");
            return 1200;
        }
        static void Main(string[] args)
        {
            Delegate8 dl = new Delegate8();
            DelegateMethod8 dm = new DelegateMethod8(dl.Test);
            dm += dl.Test1;
            dm += dl.Test2;
            int DelegateReturnValue = dm();
            Console.WriteLine("The Value of i is :" + DelegateReturnValue);
            Console.WriteLine("---------------END of the Program----------------");
        }
    }
}
