using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Widget
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to addOption a widget?(Y/N) :- ");
            string addOption = Console.ReadLine();
            string TemporaryCounter = "Y";
            while (TemporaryCounter == "Y" || TemporaryCounter == "y")
            {
                Console.Clear();
                if (addOption == "Y" || addOption == "y")
                {
                    Console.WriteLine("Which widget do you want to addOption?");
                    Console.WriteLine("(Answer just the number corresponding to the widget) ");
                    Console.WriteLine("1.Rectangle ");
                    Console.WriteLine("2.Square ");
                    Console.WriteLine("3. Circle ");
                    Console.WriteLine("4.Textbox ");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("");
                    string Shape = Console.ReadLine();
                    if (Shape == "1") //Rectangle
                    {
                        Rectangle obj = new Drawing.Rectangle();
                        obj.Main();
                    }
                    else if (Shape == "2")   //Square
                    {
                        Square obj = new Drawing.Square();
                        obj.Main();
                    }
                    else if (Shape == "3")   //Circle
                    {
                        Circle obj = new Drawing.Circle();
                        obj.Main();

                    }
                    else if (Shape == "4")   //Textbox
                    {
                        Textbox obj = new Textbox();
                        obj.Main();

                    }
                    else if (Shape == "5") // exit
                    {
                        addOption = "N";
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Wrong Entry! Try Again?");
                        Console.WriteLine("Do you want to addOption a widget?(Y/N) :-");
                        addOption = Console.ReadLine();
                        break;
                    }
                    Console.Write("Do you want to addOption another widget?(Y/N) :- ");
                    addOption = Console.ReadLine();
                    continue;
                }

                else if (addOption == "N" || addOption == "n")
                {
                    Console.WriteLine("Alright!");
                    addOption = "N";
                    break;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Wrong entry! Please enter again!");
                    Console.Write("Do you want to addOption another widget?(Y/N) :- ");
                    addOption = Console.ReadLine();
                    continue;
                }

                TemporaryCounter = addOption;
            }
            Console.ReadLine();
        }
    }
}




