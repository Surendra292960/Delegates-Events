using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public delegate void EventHandle(string a);

    class WindowEvent2
    {
        public event EventHandler xyz;

        public void Action(string a)
        {
            if(xyz != null)
            {
                //xyz(a);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Not Registered");
            }
        }
    }

    class ProgramEvent2
    {
        public static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        static void Main(string[] args)
        {
            WindowEvent2 obj = new WindowEvent2();

            obj.Action("Event Calling");
           // obj.xyz += new EventHandler(CatchEvent);

            Console.ReadLine();
        }
    }
}
