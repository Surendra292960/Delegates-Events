using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class DelegateProgram1
    {
        //  delegate int MyDelegate(int x, int y);
        delegate int MyDelegate(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 number");
            int i = int.Parse(Console.ReadLine());
           // int j = int.Parse(Console.ReadLine());
            // int k = DelegateProgram1.square1(i,j);

            MyDelegate t = Square1;
            int j = t(i);
            //t = Square1;
           // int j = t.Invoke(i);
            Console.WriteLine(j);
            Console.Read();
        }

        //static int  Square1(int x, int y)
        //{
        //    Console.WriteLine("Addition two number");
        //    return x+y;
        //}
        static int Square1(int x)
        {
            Console.WriteLine("Product of given number");
            return x * x;
        }
    }
}
