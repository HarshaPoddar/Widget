using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Drawing
{
    class Square
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate of the Sqaure :-");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate of the Square :-");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Length of the Square :- ");
            int Length = Convert.ToInt16(Console.ReadLine());
            Display disp = new Display();
            disp.Square(xCoordinate, yCoordinate, Length);


        }

    }
}
