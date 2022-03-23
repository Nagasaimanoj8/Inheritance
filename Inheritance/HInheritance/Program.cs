using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher(25054, 50000, "Sanjay", 28);
            Doctor d = new Doctor(25045, 750, "Rohit", 32);

            t.TeacherDetails();
            Console.WriteLine(
                "-----------------------------------");
            d.DoctorDetails();
        }
    }
}
