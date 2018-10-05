using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class Utility
    { 

        public static int Square(int x)
        {
            return x * x;
        }

        public static int Cuber(int x)
        {
            return x * x * x;
        }

    }
    class DelegateProgram2
    {
        delegate int MyDelegate(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 number");
            int i = int.Parse(Console.ReadLine());

            MyDelegate t = Utility.Square;
            int j = t(i);

            Console.WriteLine(j);
            Console.Read();
        }
    }
 }
