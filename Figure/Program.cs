﻿using System;
using FigureLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialX = 0;
            double finalX = 0;
            int menu;
            CurvedTrapezoid curvedTrapezoid = new CurvedTrapezoid(0,0);
            do
            {
                Console.WriteLine("*************MENU*************");
                Console.WriteLine("1. Create a curved trapezoid");
                Console.WriteLine("2. Side length calculation");
                Console.WriteLine("3. Square of a curved trapezoid");
                Console.WriteLine("4. Exit");
                Console.WriteLine("******************************");
                Console.Write("Enter menu item: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("Enter coordinate initial X: ");
                        initialX = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter coordinate final X: ");
                        finalX = Convert.ToDouble(Console.ReadLine());
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
                }
            } while (menu != 4);
        }
    }
}

