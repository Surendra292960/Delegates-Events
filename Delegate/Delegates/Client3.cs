using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void LinkToEventHandler3();

    class Client3
    {
        string name;
        public Client3(string nameArg)
        {
            name = nameArg;
        }
        public void Client1EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class EventGeneratorClass3
    {
        public static event LinkToEventHandler3 Evt;

        public static void Main()
        {
            Client3 c1_o1 = new Client3("Object1 of Client3 class");
            Client3 c1_o2 = new Client3("Object2 of Client3 class");
            Client3 c1_o3 = new Client3("Object3 of Client3 class");
            Evt += new LinkToEventHandler3(c1_o1.Client1EventHandler);
            Evt += new LinkToEventHandler3(c1_o2.Client1EventHandler);
            Evt += new LinkToEventHandler3(c1_o3.Client1EventHandler);
            DoSomething();
            Console.Read();
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
