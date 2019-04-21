using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2.Calculator calculator = new Task2.Calculator(new Task2.MyDelegate(DoIt));
            calculator.Calc();
        }
        private static void DoIt(string message)
        {
            Console.WriteLine(message);
        }
    }
}
