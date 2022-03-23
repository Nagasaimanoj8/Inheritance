using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class Father
    {
        public string FatherName()
        {
            return "Ravi";
        }
    }

    // Derived Class
    public class ChildFirst : Father
    {
        public string ChildDName()
        {
            return "Rohan";
        }
    }

    // Derived Class
    public class ChildSecond : Father
    {
        public string ChildDName()
        {
            return "Nikhil";
        }
    }
    // Derived Class
    public class ChildThird : Father
        {
            public string ChildDName()
            {
                return "Manoj"; 
            }
        }
    }

