using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student : Person
    {
       public enum gradeLevels { firstYear, Sophomore, Junior, senior}
        public gradeLevels gradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 5;
        }
    }
}
