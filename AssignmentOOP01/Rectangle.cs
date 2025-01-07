using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal class Rectangle
    {
        private double width;
        private double height;


        public double Width
        {
            get { return width; }
            set { width = value > 0 ? value:-value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value > 0 ? value : -value; }
        }


        public double Area
        {
            get { return width * height; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"width = {width}\nheight = {height}\nArea = {Area}");
        }

    }
}
