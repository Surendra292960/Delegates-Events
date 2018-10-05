using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    delegate void operation();
    class Delegate2
    {
        static void Main(string[] args)
        {
            operation obj = delegate
            {
                Console.WriteLine("Anonymous method");
            };
            obj();

            Console.ReadLine();
        }
    }
}
