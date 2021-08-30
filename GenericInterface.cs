using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericInterface
    {
        interface ITest
        {
            void Message();
        }

        class Test : ITest
        {
            public void Message()
            {
                Console.WriteLine("MESSAGE");
            }
        }

        class Program
        {
            static void Main()
            {
                // Create Test object.
                Test test = new Test();
                test.Message();

                // Convert the class to its interface.
                ITest perl = test as ITest;
                if (perl != null)
                {
                    perl.Message();
                };
            }
        }
    }
}
