using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person
    {

        public string Name; // Field Name
        public Person(string name)
        {
            Name = name;
        }
        public void Introduce()
        { // access_modifier return_type method_name
            Console.WriteLine($"Hello, {Name}");
        }
    }
}
