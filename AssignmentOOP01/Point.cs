using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    internal struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    } 
    #endregion
}
