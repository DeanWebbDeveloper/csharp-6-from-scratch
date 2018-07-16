using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
        class Worker
        {
            public Worker()
            {
                Work();
            }

        public void Work()
        {
            {
                var listOfInt = new List<int>
                {
                    2,
                    7,
                    3,13,5,18,18
                };

                var smallerNumbers = from num in listOfInt
                                     where num < 8
                                     select num;

                foreach(int number in smallerNumbers)
                {
                    Console.WriteLine($"Value: {number}");
                }

                Console.WriteLine("\n --------------------------\n");

                var smallerNumbers2 = listOfInt
                    .Where(n => n < 8)
                    .Select(n => n);

                foreach(int number2 in smallerNumbers2)
                {
                    Console.WriteLine($"Value: {number2}");
                }
            }
        }
    }
}
