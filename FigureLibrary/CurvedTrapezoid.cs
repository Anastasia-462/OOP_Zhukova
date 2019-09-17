using System;
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

        public void FigureSquare(double XInitial, double XFinal)
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
            Console.WriteLine("Square of a curved trapezoid: {0}", P);
        }

    }
}
