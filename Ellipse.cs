using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Drawing
{
    class Ellipse
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate of the Ellipse :-");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate of the Ellipse :-");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Length of the Ellipse :- ");
            int Length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the height of the Ellipse :- ");
            int Height = Convert.ToInt16(Console.ReadLine());

            Display disp = new Display();
            disp.Ellipse(xCoordinate, yCoordinate, Length, Height);


        }
    }
}
