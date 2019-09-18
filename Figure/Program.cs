using System;
using FigureLibrary;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialX = 0;
            double finalX = 0;
            //Check condition.
            int menu;
            CurvedTrapezoid curvedTrapezoid = new CurvedTrapezoid(0,0);
            do
            {
                Console.WriteLine("                              ");
                Console.WriteLine("*************MENU*************");
                Console.WriteLine("1. Create a curved trapezoid");
                Console.WriteLine("2. Side length calculation");
                Console.WriteLine("3. Square of a curved trapezoid");
                Console.WriteLine("4. Perimeter of a curved trapezoid");
                Console.WriteLine("5. Checking the belonging of a poiunt to a figure");
                Console.WriteLine("6. Exit");
                Console.WriteLine("******************************");
                Console.Write("Enter menu item: ");
                Int32.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        Console.Write("Enter coordinate initial X: ");
                        //TryParse converts a string to a number if the entered string doesn't
                        //contain numbers and asks to re-enter.
                        Double.TryParse(Console.ReadLine(), out initialX);
                        Console.Write("Enter coordinate final X: ");
                        Double.TryParse(Console.ReadLine(), out finalX);
                        curvedTrapezoid.ExistenceCheck(initialX, finalX);
                        break;
                    case 2:
                        if (curvedTrapezoid.ExistenceCheck(initialX, finalX))
                        {
                            curvedTrapezoid.SideLengthCalculation(initialX, finalX);
                        }
                        break;
                    case 3:
                        if (curvedTrapezoid.ExistenceCheck(initialX, finalX))
                        {
                            curvedTrapezoid.FigureSquare(initialX, finalX);
                        }
                        break;
                    case 4:
                        if (curvedTrapezoid.ExistenceCheck(initialX, finalX))
                        {
                            curvedTrapezoid.FigurePerimeter(initialX, finalX);
                        }
                        break;
                    case 5:
                        curvedTrapezoid.PointOwnershipCheck(initialX, finalX);
                        break;
                }
            } while (menu != 6);
        }
    }
}

