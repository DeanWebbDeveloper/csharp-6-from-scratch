using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"counter = {counter.ToString()}");
                counter++;
            } while (counter < 0) ;
        }
    }
}
