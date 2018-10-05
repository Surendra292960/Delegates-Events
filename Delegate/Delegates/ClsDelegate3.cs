using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class ClsDelegate3
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sume is:" + (a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Difference is:" + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Product is:" + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Quotient is:" + (a / b));
        }

        public delegate void McDelegate(int a, int b);
        class Clsmulticast
        {
            static void Main(string[] args)
            {
                ClsDelegate3 obj1 = new ClsDelegate3();
                obj1.Add(10,20);
                obj1.Sub(10, 20);
                obj1.Mul(10, 20);
                obj1.Div(10, 20);
              
                McDelegate objd = new McDelegate(obj1.Add);

                objd += obj1.Sub;
                objd -= obj1.Mul;
                objd += obj1.Div;

                //objd(10, 20);

                //objd -= obj1.Mul;
                //objd -= obj1.Div;

                //objd(30, 40);

                Console.Read();
            }
        }
    }
}
