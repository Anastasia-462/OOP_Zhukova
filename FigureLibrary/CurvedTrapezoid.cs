﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class CurvedTrapezoid
    {
        double XInitial { get; set; }
        double XFinal { get; set; }
        public CurvedTrapezoid(double XInitial, double XFinal)
        {
            this.XInitial = XInitial;
            this.XFinal = XFinal;
        }
        public bool ExistenceCheck(double XInitial, double XFinal)
        {
            if (((XInitial < 0 ) && (XFinal > 0)) || ((XInitial > 0) && (XFinal < 0)) || (XInitial == XFinal))
            {
                Console.WriteLine("A figure cannot exist.");
                return false;
            }
            else
            {
                Console.WriteLine("Data entered is correct.");
                return true;
            }
        }
        public void SideLengthCalculation(double XInitial, double XFinal)
        {
            double X;
            double curve;
            if (XInitial > XFinal)
            {
                X = XInitial;
                XInitial = XFinal;
                XFinal = X;
            }
            curve = 0.5 * XFinal * Math.Sqrt(1 + 4 * Math.Pow(XFinal, 2)) + 0.25 * Math.Log(Math.Abs(2 * XFinal + Math.Sqrt(1 + 4 * Math.Pow(XFinal, 2)))) - 0.5 * XInitial * Math.Sqrt(1 + 4 * Math.Pow(XInitial, 2)) - 0.25 * Math.Log(Math.Abs(2 * XInitial + Math.Sqrt(1 + 4 * Math.Pow(XInitial, 2))));
            Console.WriteLine("X-axis length: {0}; x-axis length from above: {1}", XFinal - XInitial, curve);
            Console.WriteLine("Y-axis length on the right: {0}; y-axis on the left: {1}", Math.Pow(XInitial, 2), Math.Pow(XFinal, 2));
        }

        public void FigurePerimeter(double XInitial, double XFinal)
        {
            double X;
            double curve;
            double P;
            if (XInitial > XFinal)
            {
                X = XInitial;
                XInitial = XFinal;
                XFinal = X;
            }
            curve = 0.5 * XFinal * Math.Sqrt(1 + 4 * Math.Pow(XFinal, 2)) + 0.25 * Math.Log(Math.Abs(2 * XFinal + Math.Sqrt(1 + 4 * Math.Pow(XFinal, 2)))) - 0.5 * XInitial * Math.Sqrt(1 + 4 * Math.Pow(XInitial, 2)) - 0.25 * Math.Log(Math.Abs(2 * XInitial + Math.Sqrt(1 + 4 * Math.Pow(XInitial, 2))));
            P = curve + (XFinal - XInitial) + Math.Pow(XInitial, 2) + Math.Pow(XFinal, 2);
            Console.WriteLine("Perimeter of a curved trapezoid: {0}", P);
        }

        public void FigureSquare(double XInitial, double XFinal)
        {
            double S;
            double X;
            if (XInitial > XFinal)
            {
                X = XInitial;
                XInitial = XFinal;
                XFinal = X;
            }
            S = Math.Pow(XFinal, 3) / 3 - Math.Pow(XInitial, 3) / 3;
            Console.WriteLine("Square of a curved trapezoid: {0}", S);
        }
        public void PointOwnershipCheck(double XInitial, double XFinal)
        {
            double X;
            double Y;
            double YInitial = Math.Pow(XInitial, 2);
            double YFinal = Math.Pow(XFinal, 2);
            Console.WriteLine("Enter X coordinate: ");
            while (!Double.TryParse(Console.ReadLine(), out X))
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Enter X coordinate: ");
            }
            Console.WriteLine("Enter Y coordinate: ");
            while (!Double.TryParse(Console.ReadLine(), out Y))
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Enter Y coordinate: ");
            }
            if (((X == XInitial) && (Y <= YInitial)) || ((X == XFinal) && (Y <= YFinal)) || (Y - 0.5 * Math.Pow(X, 2) == 0))
            {
                Console.WriteLine("Lies on the border of the figure.");
            }
            else if ((X > XInitial) && (X < XFinal) && (Y > 0) && (Y < YFinal) && (Y - 0.5 * Math.Pow(X, 2) < 0))
            {
                Console.WriteLine("Belongs to a given figure.");
            }
            else
            {
                Console.WriteLine("Does not belong to a given figure.");
            }
        }
    }
}
