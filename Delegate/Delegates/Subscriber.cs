using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public class Subscriber
    {
        private Publisher publishers;
        public Subscriber(Publisher publisher)
        {
            this.publishers = publisher;
            publishers.ProdcutAddedInfo += publishers_ProdcutAddedInfo;
        }
        void publishers_ProdcutAddedInfo(object sender, EventArgs e)
        {
            if (sender == null)
            {
                Console.WriteLine("No New Product Added.");
                return;
            }
            Console.WriteLine("A New Prodct Added.");
        }
        public void UnSubscribeEvent()
        {
            publishers.ProdcutAddedInfo -= publishers_ProdcutAddedInfo;
        }
    }
}
