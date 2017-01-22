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
            int Breadth = Convert.ToInt16(Console.ReadLine());


            Console.Clear();

            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int index = 0; index < xCoordinate; index++)
                Console.Write(" ");
            Console.WriteLine("Shape :- Ellipse");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The Length of the Ellipse = {0} cms", Length);
            Console.WriteLine("The height of the Ellipse = {0} cms", Breadth);
        }
    }
}
