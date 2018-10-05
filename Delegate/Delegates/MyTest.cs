using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Delegates
{
    public class MyTest
    {
        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("add operation");
            }
            remove
            {
                Console.WriteLine("remove operation");
            }
        }
    }
    public class Test
    {
        public void TestEvent()
        {
            MyTest myTest = new MyTest();
            myTest.MyEvent += myTest_MyEvent;
            myTest.MyEvent -= myTest_MyEvent;
        }
        public void myTest_MyEvent(object sender, EventArgs e)
        {
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            test.TestEvent();
            Console.ReadKey();
        }
    }
}
