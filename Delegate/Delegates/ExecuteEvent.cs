using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    class ExecuteEvent
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);
            publisher.Add(new Product
            {
                 ProductName = "Pasta",
                Price = 20
            });
            publisher.Add(new Product
            {
                ProductName = "Horlics",
                Price = 120
            });
            publisher.Add(new Product
            {
                ProductName = "Boost",
                Price = 200
            });

            publisher.Add(new Product
            {
                ProductName = "Vitamin",
                Price = 300
            });


            subscriber.UnSubscribeEvent();
            Console.ReadKey();
        }
    }
}
