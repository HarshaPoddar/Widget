using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Display
    {
        public void Rectangle(int xCoordinate, int yCoordinate, int length, int breadth)
        {
            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int Counter = 0; Counter < xCoordinate; Counter++)
                Console.Write(" ");
            Console.WriteLine("Shape :- RECTANGLE");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The Length of the Rectangle = {0} cms", length);
            Console.WriteLine("The Breadth of the Rectangle = {0} cms ", breadth);
        }
        public void Textbox(int xCoordinate, int yCoordinate, string Text)
        {
            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int index = 0; index < xCoordinate; index++)
                Console.Write(" ");
            Console.WriteLine("Shape :- Textbox");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The text in the textbox = {0}", Text);
        }
        public void Square(int xCoordinate, int yCoordinate, int length)
        {
            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int index = 0; index < xCoordinate; index++)
                Console.Write(" ");
            Console.WriteLine("Shape :- Ellipse");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The Length of the Square = {0} cms :- ", length);
        }
        public void Ellipse(int xCoordinate, int yCoordinate, int length, int Height)
        {
            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int index = 0; index < xCoordinate; index++)
                Console.Write(" ");
            Console.WriteLine("Shape :- Ellipse");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The Length of the Ellipse = {0} cms", length);
            Console.WriteLine("The height of the Ellipse = {0} cms", Height);
        }
        public void Circle(int xCoordinate, int yCoordinate, int diameter)
        {
            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int index = 0; index < xCoordinate; index++)
                Console.Write(" ");
            Console.WriteLine("Shape :- Ellipse");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The Diameter of the Circle = {0} cms", diameter);
        }
    }
}

