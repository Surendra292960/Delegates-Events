using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class Utility1
    {
        public  delegate int Transformer(int x);

        public static int Transform(int x, Transformer t)
        {
            return x = t(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            int result = Utility1.Transform(i,Cuber);
            Console.WriteLine(result);
            Console.Read();
        }

        public static int Square(int x)
        {
            return x * x;
        }
        public static int Cuber(int x)
        {
            return x * x * x;
        }
    }
}
