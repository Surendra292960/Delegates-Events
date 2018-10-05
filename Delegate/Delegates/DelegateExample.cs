using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{

    //This is All about static 

    class DelegateExample
    {
        public  delegate int Calculator(int n);
        static int number = 100;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }

        public static int div(int n)
        {
            number = number * n;
            return number;
        }

        public static int mul(int n)
        {
            number = number * n;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add);
            Calculator c2 = new Calculator(mul);
            Calculator c3 = new Calculator(div);

            c1(20);
            Console.WriteLine("After c1 delegate, Number addition is:" + getNumber());

            c2(3);
            Console.WriteLine("After c2 delegate, Number multiplication is:" + getNumber());

            c3(4);
            Console.WriteLine("After c3 delegate, Number division  is:" + getNumber());

            Console.Read();
        }
    }
}
