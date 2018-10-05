using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class Multicast
    {
        public static void Add(int a)
        {
            Console.WriteLine("Addition={0}", a + 10);
        }
        public static void Square(int a)
        {
            Console.WriteLine("Multiply={0}", a * a);
        }
    }

    class MultipleDelegates
    {
        delegate void OperationDelegate(int x);
        static void Main(string[] args)
        {
            OperationDelegate
            obj = Multicast.Add;
            obj += Multicast.Square;

            obj(2);
            obj(8);

            Console.ReadLine();
        }
    }
}
