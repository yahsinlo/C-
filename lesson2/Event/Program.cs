using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {

        static void Main(string[] args)
        {
            var e = new EventTest(5);
            e.ChangNum += new EventTest.NumManipulationHandler(EventTest.EventFired);
            e.Setvalue(50);
            //e.Setvalue(100);

            I i=new Myclass();
            i.MyEvent += new MyDelegate(f);
            i.FireAway();
            Console.WriteLine();
        }
        private static void f()
        {
            Console.WriteLine("This is called when the event fired");
        }
    }
    class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangNum;

        public EventTest(int n)
        {
            Setvalue(n);
        }

        public static void EventFired()
        {
            Console.WriteLine("Binded Event");
        }

        protected virtual void OnNumChange()
        {
            if (ChangNum != null)
            {
                ChangNum();
            }
            else
            {
                Console.WriteLine("event starts!");
            }
        }

        public void Setvalue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChange();
            }
        }
    }

    public delegate void MyDelegate();
    public interface I
    {
        event MyDelegate MyEvent;
        void FireAway();
    }

    public class Myclass : I
    {
        public event MyDelegate MyEvent;
        public void FireAway()
        {
            if (MyEvent != null)
                MyEvent();
        }
    }
}
