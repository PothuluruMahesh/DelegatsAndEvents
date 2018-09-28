using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Delegate
    {
        public void Test()
        {
            Console.WriteLine("From Test()");
        }
        public void Test1(int i,int j)
        {
            Console.WriteLine("From Test(int , int)");
        }
        public static void Test2()
        {
            Console.WriteLine("From Static Test()");
        }
        public  static void Test3(int i, int j)
        {
            Console.WriteLine("From Static Test3(int , int)");
        }
        static int i;
        public static int Test4()
        {
            Console.WriteLine("From Static Test4(Return)");
            return i=420;
        }
        static void Main(string[] args)
        {
            Delegate pr = new Delegate();
            pr.Test();//calling with refference
            pr.Test1(10, 20);//calling with reference by passing parameters
            Test2();//calling directly
            Test3(40, 50);//calling direclty with parameter
            Test4();// calling the method which is having return type
            Console.WriteLine("The Return Value Is :" + i);
            Console.WriteLine("---------THis is the normal way to call any Methods-------");
        }
    }
}
