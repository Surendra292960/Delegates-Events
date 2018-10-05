using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{

    //type safe we can't supply any other datatype

    public delegate int Operation(int a, int b);
    class Deligate1
    {
        static int Addition(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Operation obj = new Operation(Deligate1.Addition);
            Console.WriteLine("Addition is={0}", obj(23,20));
            Console.Read();
        }
    }
}
