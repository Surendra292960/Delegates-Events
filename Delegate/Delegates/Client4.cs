using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void LinkToEventHandler4();

    class Client4
    {
        string name;
        public Client4(string nameArg)
        {
            name = nameArg;
        }
        public void Client1EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class Client5
    {
        string name;
        public Client5(string nameArg)
        {
            name = nameArg;
        }
        public void Client2EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class EventGeneratorClass4
    {
        public static event LinkToEventHandler4 Evt;

        public static void Main()
        {
            Client4 c1_o1 = new Client4("Object1 of Client4 class");
            Client4 c1_o2 = new Client4("Object2 of Client4 class");
            Client4 c1_o3 = new Client4("Object3 of Client4 class");

            Client5 c2_o1 = new Client5("Object1 of Client5 class");
            Client5 c2_o2 = new Client5("Object2 of Client5 class");
            Client5 c2_o3 = new Client5("Object3 of Client5 class");

            Evt += new LinkToEventHandler4(c1_o1.Client1EventHandler);
            Evt += new LinkToEventHandler4(c1_o2.Client1EventHandler);
            Evt += new LinkToEventHandler4(c1_o3.Client1EventHandler);

            Evt += new LinkToEventHandler4(c2_o1.Client2EventHandler);
            Evt += new LinkToEventHandler4(c2_o2.Client2EventHandler);
            Evt += new LinkToEventHandler4(c2_o3.Client2EventHandler);

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
