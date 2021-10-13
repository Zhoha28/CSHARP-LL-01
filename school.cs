using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class school
    {
        // auto properties
        public String schoolName {
            get;
            set;
        }
        public String schoolAddress
        {
            get;
            set;
        }
        public String schoolState
        {
            get;
            set;
        }
        public String schoolPhone
        {
            get;
            set;
        }


        // create a backing variable to store value
        private String _twitterAddress; // private as we dont want backing variable to be accidentally changed
        public String TwitterAddress
        {
            // making sure that twitter address starts with a @.
            get {
                return _twitterAddress;
            }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("Twitter address must begin with @");
                }
            }
        }


        //constructors 
        // constructor doesnt have a return type
        // shortcut - ctor + tab + tab
        public school()
        {
            schoolName = "Untitled School";
            schoolAddress = "Kitchener, On";

        }


        // constructor with params
        public school(String SchoolName, String PhoneN)
        {
            schoolName = SchoolName;
            schoolPhone = PhoneN;
        }


        //overloading... - same names for methods, but different signatures
        //methods
        //public float AdditionNumbers(float a, float b)
        //{
        //    var result = a + b;
        //    return result;
        //}

        // function bodied expressions
        public static float AdditionNumbers(float a, float b) => (a + b);

        // method
        public static int AdditionNumbers(int a, int b)
        {
            return a + b;
        }


        // every class can be converted to string, thus its a good idea to override it.
        public override string ToString()
        {

            //return base.ToString(); -- default


            var sb = new StringBuilder();
            sb.AppendLine(schoolName);
            sb.AppendLine(schoolAddress);
            sb.AppendLine(schoolPhone);
            sb.AppendLine(schoolState);

            return sb.ToString();
        }
    }
}
