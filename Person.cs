using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public abstract class Person // abstract so people cannot directly instantiate it
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        //method
        public abstract float ComputeGradeAverage();
    }
}
