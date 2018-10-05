using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class ArrayofDelegate
    {

        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition={0}", x + y);
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication={0}", x * y);
        }
    }

    class ArrayDelegates
    {
        public delegate void Delegateoperation(int x, int y);

        static void Main(string[] args)
        {
            Delegateoperation[] obj1 =
                {
                new Delegateoperation(ArrayofDelegate.Add),
                new Delegateoperation(ArrayofDelegate.Multiply)
                };

            for(int i = 0; i< obj1.Length; i++)
            {
                obj1[i](2, 5);
                obj1[i](8, 5);
                obj1[i](4, 6);
                obj1[i](2, 7);
            }
            Console.ReadLine();
        }

    }
}
