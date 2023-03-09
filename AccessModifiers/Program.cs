using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer {
        private int id { get; set; }
        public void Save()
        {

        }
    
    }
    // private is only valid inside the block
    // protected can be used wirth inheritance while private can not
    // classess can not be private or protected except nested classes
    // default for variables is private whlie for classes default is internal
    // internal can be used inside same project
    // public can be used even from outside of the project
    class Student:Customer
    {
        void Save2()
        {
            
        }
    }

    public class Course
    {
        public class CourseNested
        {

        }
        CourseNested s = new CourseNested();
    }
}
