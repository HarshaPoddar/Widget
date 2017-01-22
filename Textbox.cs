using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Drawing
{
    class Textbox
    {
        public void Main()
        {
            Console.WriteLine("Enter the x co-ordinate of the Textbox :-");
            int xCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the y co-ordinate of the Textbox :-");
            int yCoordinate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Text to be printed :- ");
            String Text = Console.ReadLine();

            Display disp = new Display();
            disp.Textbox(xCoordinate, yCoordinate,Text);

        }

    }
}
