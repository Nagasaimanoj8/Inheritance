using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildFirst first = new ChildFirst();

            
            Console.WriteLine("My name is " + first.ChildDName() +
                              ". My father name is " +
                              first.FatherName() + ".");
            ChildSecond second = new ChildSecond();

            Console.WriteLine("My name is " + second.ChildDName() +
                              ". My father name is " +
                              second.FatherName() + ".");
            ChildThird third = new ChildThird();
            Console.WriteLine("My name is " + third.ChildDName() + ". My Father Name is " +
                              third.FatherName() + ".");
        }
    }
}
