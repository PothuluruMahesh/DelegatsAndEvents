using System;

namespace DelegatesAndEvents
{
    public class Adder
    {
        public delegate void dgEventRaiser();
        public event dgEventRaiser OnMultipleOfFiveReached;

        public int Add(int x, int y)
        {
            int Sum = x + y;
            if ((Sum % 5 == 0) && (OnMultipleOfFiveReached != null))
            {
                OnMultipleOfFiveReached();
            }
            return Sum;
        }
    }
    class Event3
    {
        static void Main()
        {
            Adder a = new Adder();
            a.OnMultipleOfFiveReached += new Adder.dgEventRaiser(MultipleOfFiveReached);

            int i = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", i);
            i = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", i);
        }

        static void MultipleOfFiveReached()
        {
            Console.WriteLine("Multiple of five reached!");
        }
    }
}