using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelegateMethod5(int i,int j);
    public delegate int DelegateMethod4();  //return type must be same as delegate

    class Delegate4
    {
        public int Test()
        {
            Console.WriteLine("From Test(return type)");
            return 2;
        }
        public void Test1(int i,int j)
        {
            Console.WriteLine("From Test1(int i,int j) :"+i+"::"+j);
            
        }
        static void Main(string[] args)
        {
            Delegate4 dl = new Delegate4();
            DelegateMethod4 dm = dl.Test;
            dm();
            DelegateMethod5 dm1 = dl.Test1;
            dm1(10,20);
        }
    }
}
