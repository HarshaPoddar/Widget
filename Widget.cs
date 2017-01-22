using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    class Execute
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to add a widget?(Y/N) :- ");
            char add = Convert.ToChar(Console.ReadLine());
            char Temporary = 'Y';
            while (Temporary == 'Y' || Temporary == 'y')
            {
                Console.Clear();
                if (add == 'Y' || add == 'y')
                {
                    Console.WriteLine("Which widget do you want to add?");
                    Console.WriteLine("(Answer just the number corresponding to the widget) ");
                    Console.WriteLine("1.Rectangle ");
                    Console.WriteLine("2.Square ");
                    Console.WriteLine("3. Circle ");
                    Console.WriteLine("4.Textbox ");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("");
                    char Answer = Convert.ToChar(Console.ReadLine());
                    if (Answer == '1')
                    {
                        Rectangle obj = new Drawing.Rectangle();
                        obj.Main();
                    }
                    else if (Answer == '2')
                    {
                        Square obj = new Drawing.Square();
                        obj.Main();
                    }
                    else if (Answer == '3')
                    {
                        Circle obj = new Drawing.Circle();
                        obj.Main();

                    }
                    else if (Answer == '4')
                    {
                        Textbox obj = new Textbox();
                        obj.Main();

                    }
                    else if (Answer == '5')
                    {
                        add = 'N';
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Entry! Try Again?");
                        Console.WriteLine("Do you want to add a widget?(Y/N) :-");
                        add = Convert.ToChar(Console.ReadLine());
                        continue;
                    }
                    Console.Write("Do you want to add another widget?(Y/N) :- ");
                    add = Convert.ToChar(Console.ReadLine());
                    continue;
                }

                else if (add == 'N' || add == 'n')
                {
                    Console.WriteLine("Alright!");
                    add = 'N';
                    break;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Wrong entry! Please enter again!");
                    Console.Write("Do you want to add another widget?(Y/N) :- ");
                    add = Convert.ToChar(Console.ReadLine());
                    continue;
                }

                Temporary = add;
            }
            Console.ReadLine();
        }
    }
}




