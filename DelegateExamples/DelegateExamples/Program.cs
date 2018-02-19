using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    class Program
    {
        // Declare the delegate type used
        public delegate int MyDelegate(int i, string s);

        static void Main(string[] args)
        {
            // myFuntion declaration.
            int myFunction(int index, string value)
            {
                // Function implementation.
                Console.WriteLine("myFunction is being executed, data received: index = " + index + "; value = " + value + ".");
                return 0;
            }

            // myFunction2 declaration.
            int myFunction2(int index, string value)
            {
                // Function implementation.
                Console.WriteLine("myFunction2 is being executed, data received: index = " + index + "; value = " + value + ".");
                return 0;
            }

            // Delegate declaration. Link delegate f to myFunction.
            MyDelegate f = myFunction;

            // Call and execute delegate.
            int result = f(114, "my-value");

            // Switching delegate implementation.
            f = myFunction2;
            result = f(123, "another-value");

            // Anonymously declare a delegate.
            MyDelegate anonymousDelegate = delegate (int index, string value)
            {
                // Function implementation.
                Console.WriteLine("An anonymous delegate is being executed, data received: index = " + index + "; value = " + value + ".");
                return 0;
            };

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

        }
    }
}
