using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void DelEventHandler();
    class WindowEvent1
    {
        public static DelEventHandler add;
        static void Main(string[] args)
        {
            add += new DelEventHandler(USA);
            add += new DelEventHandler(INDIA);
            add += new DelEventHandler(ENGLAND);
            add += new DelEventHandler(GERMANY);
            add.Invoke();
            Console.ReadKey();
        }
        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void INDIA()
        {
            Console.WriteLine("INDIA");
        }

        static void ENGLAND()
        {
            Console.WriteLine("ENGLAND");
        }
        static void GERMANY()
        {
            Console.WriteLine("GERMANY");
        }
    }
}
