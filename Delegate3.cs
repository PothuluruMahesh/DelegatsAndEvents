using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
     public delegate int DelegateMethod3();  //return type must be same as delegate

        class Delegate3
        {
            public int Test()
            {
                Console.WriteLine("From Test(return type)");
                return 2;
            }
            public int Test1()
            {
                Console.WriteLine("From Test1(return type)");
                return 1;
            }
            static void Main(string[] args)
            {
                Delegate3 dl = new Delegate3();
                DelegateMethod3 dm = dl.Test;
                dm();
                DelegateMethod3 dm1 = dl.Test1;
                dm1();
            }
        }
}

