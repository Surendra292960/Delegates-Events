using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void Transformer(int x); 
    class Events
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t;

            t = Square;

            t += Cuber;

            t.Invoke(i);

            NotificationofMethods obj = new NotificationofMethods();
            obj.transformerEvent += User1.Xhandler;
            obj.transformerEvent += User2.Yhandler;

            obj.NotifyCell(i);

            Console.ReadLine();
        }

        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }

        static void Cuber(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }

    class NotificationofMethods
    {
        public event Transformer transformerEvent;

        public void NotifyCell(int x)
        {
            if(transformerEvent != null)
                {
                transformerEvent(x);
                }
        }
    }

    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event recieved by User1 object");
        }
    }

    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event recieved by User2 objject");
        }
    }
}
