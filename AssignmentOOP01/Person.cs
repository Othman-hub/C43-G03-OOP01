using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) 
        { 
            Name = name; 
            Age = age; 
        }
        public override string ToString() { return $"Person Name: {Name}\nPerson Age: {Age}"; }

    } 
    #endregion
}
