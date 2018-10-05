using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class ClsDelegate
    {
        static void Display(string s)
        {
            Console.WriteLine("value of s is:" + s);
        }
        public delegate void mydelegate(string a);

        static void Main(string[] args)
        {
            mydelegate obj1 = new mydelegate(Display);
            ClsDelegate obj = new ClsDelegate();
            obj1("Hello");
            Console.Read();
        }
    }
}
