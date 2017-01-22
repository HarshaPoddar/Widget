using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Circle
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate of the Circle :-");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate of the Circle :-");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the diameter of the Circle :- ");
            int Diameter = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            for (int index = 0; index < yCoordinate; index++)
                Console.WriteLine("");
            for (int index = 0; index < xCoordinate; index++)
                Console.Write(" ");
            Console.WriteLine("Shape :- Ellipse");
            Console.WriteLine("Location:- x co-ordinate = {0} cms", xCoordinate);
            Console.WriteLine("Location:- y co-ordinate = {0} cms", yCoordinate);
            Console.WriteLine("The Diameter of the Circle = {0} cms", Diameter);
        }
    }
}
