using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class ClsDelegate1
    {
        public void Display(string s)
        {
            Console.WriteLine("Value of s is:" + s);
        }
    }

    public delegate void sampledelegate(string a);

    class ClsDelegate2
    {
        static void Main(string[] args)
        {
            ClsDelegate1 obj1 = new ClsDelegate1();
            sampledelegate objd = new sampledelegate(obj1.Display);
            objd("welcome");
            Console.Read();
        }
    }
}
