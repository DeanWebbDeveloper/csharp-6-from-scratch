using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Person george = new Person() { Name = "George", Age = 67 };
            string key = "george";
            dict.Add(key, george);

            dict.Add("john", new Person() { Name = "John", Age = 44 });
            dict.Add("thomas", new Person() { Name = "Thomas", Age = 80});
            dict.Add("james", new Person() { Name = "James", Age = 61 });

            Person secondPerson = dict["john"];
            Console.WriteLine($"secondPerson = {secondPerson.Name}");        }
    }
}
