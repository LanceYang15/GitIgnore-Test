using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIgnoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            Hidden hidden = new Hidden();

            hello.Greeting();
            hidden.DisplayName();
            Console.ReadKey();
        }
    }
}
