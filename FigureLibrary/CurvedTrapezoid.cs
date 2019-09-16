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
        public void ExistenceCheck(double XInitial, double XFinal)
        {
            if (((XInitial < 0 ) && (XFinal > 0)) || ((XInitial > 0) && (XFinal < 0)) || ((XInitial == 0) && (XFinal == 0)))
            {
                Console.WriteLine("A figure cannot exist.");
            }
            else
            {
                Console.WriteLine("Data entered is coorect.");
            }
        }

    }
}
