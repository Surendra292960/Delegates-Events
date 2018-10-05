using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void LinkToEventHandler2();

    class Client2
    {
        string name;
        public Client2(string nameArg)
        {
            name = nameArg;
        }
        public void Client1EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class EventGeneratorClass2
    {
        public static event LinkToEventHandler2 Evt;

        public static void Main()
        {
            Client1 c1_o1 = new Client1("Object1 of Client1 class");
            Evt += new LinkToEventHandler2(c1_o1.Client1EventHandler);
            DoSomething();
            Console.ReadLine();
        }

        public static void DoSomething()
        {
            System.Console.WriteLine("Something Happened! We need to send an event.");
            SendEvent();
        }

        public static void SendEvent()
        {
            if (Evt != null)
            {
                Evt();
            }
        }
    }
}
