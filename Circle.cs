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

            Display disp = new Display();
            disp.Circle(xCoordinate, yCoordinate, Diameter);
        }
    }
}
