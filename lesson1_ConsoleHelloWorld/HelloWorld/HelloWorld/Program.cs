using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class TestClass
    {
        const double Pi = 3.1415;
        readonly int i;
        TestClass()
        {
            i = 100;
        }

    }
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("hello world!\n");
            Console.ReadLine();

        }
    }
}
