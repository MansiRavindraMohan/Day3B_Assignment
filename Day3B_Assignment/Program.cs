using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConstructorTypes typesConstructors = new ConstructorTypes();
            ConstructorTypes types = new ConstructorTypes(145, "Mansi");
            ConstructorTypes typesTwo = new ConstructorTypes(types);
            Console.ReadLine();
        }
    }
}
