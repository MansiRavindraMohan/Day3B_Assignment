using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_Assignment
{
    public class ConstructorTypes
    {
        //Default Constructor
        public ConstructorTypes()
        {
            Console.WriteLine("This is example of default constructor");
        }
        //Parameterised Constructor
        public int Id;
        public string Name;
        public ConstructorTypes(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Console.WriteLine("This is example of Parameterised constructor");
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
        //Copy Constructor
        public ConstructorTypes(ConstructorTypes other)
        {
            this.Id = other.Id;
            this.Name = other.Name;
            Console.WriteLine("This is example of Copy constructor");
            Console.WriteLine(other.Name);
            Console.WriteLine(other.Id);
        }
    }
}
