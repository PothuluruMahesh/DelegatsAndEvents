using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Event2
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.EvOddNumber += new AddTwoNumbers.DeOddNumber(EventMessage);//4
            a.Add();
        }
        static void EventMessage()//5
        {
            Console.WriteLine("********Event Executed : This is Odd Number**********");
        }
    }

    class AddTwoNumbers
    {
        public delegate void DeOddNumber(); //Declared Delegate 1    
        public event DeOddNumber EvOddNumber; //Declared Events 2

        public void Add()
        {
            Console.WriteLine("Enter Odd number to Rise an Event");
            int result=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you Entered Number is :"+result);

            if ((result % 2 != 0) && (EvOddNumber != null))
            {
                EvOddNumber();//event will rise if u enter odd number 3
            }
        }
    }
}