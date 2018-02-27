using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIgnoreTest
{
    class Hidden
    {
        string name;

        public Hidden()
        {
            name = "Lance";
        }

        public void DisplayName()
        {
            Console.WriteLine("Hi my name is " + name);
        }
    }
}
