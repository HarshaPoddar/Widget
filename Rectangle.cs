using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Rectangle
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate of the Rectangle :-");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate of the Rectangle :-");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Length of the Rectangle :- ");
            int Length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle :- ");
            int Breadth = Convert.ToInt16(Console.ReadLine());

            Display disp = new Display();
            disp.Rectangle(xCoordinate, yCoordinate, Length, Breadth);
        }
    }
}


