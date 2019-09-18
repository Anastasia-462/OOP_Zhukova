using System;

namespace FigureLibrary
{
    /// <summary>
    /// The main Figure class.
    /// This class describes a curved trapezoid. 
    /// </summary>
    public class CurvedTrapezoid
    {
        //Create two variables that specify the gap in which the trapezois is.

        double XInitial { get; set; }
        double XFinal { get; set; }
        /// <summary>
        /// Makes private variables public.
        /// </summary>
        /// <param name="XInitial">A double variable. Initial gap value.</param>
        /// <param name="XFinal">A double variable. Final gap value</param>
        public CurvedTrapezoid(double XInitial, double XFinal)
        {
            this.XInitial = XInitial;
            this.XFinal = XFinal;
        }
        /// <summary>
        /// This method checks if the curved trapezoid exists.
        /// </summary>
        /// <param name="XInitial">>A double.</param>
        /// <param name="XFinal">A double.</param>
        /// <returns>Returns true if the curved trapezoid.
        /// And false if not exists.
        /// </returns>
        public bool ExistenceCheck(double XInitial, double XFinal)
        {
            //If initial gap value less than zero and final gap value greater than zero.
            //Or if initial gap value greater than zero and final gap value less than zero.
            //Or initial gap value is equal to final gap value.
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
        /// <summary>
        /// This method calculates the length of each side.
        /// </summary>
        /// <param name="XInitial">A double.</param>
        /// <param name="XFinal">A double.</param>
        public void SideLengthCalculation(double XInitial, double XFinal)
        {
            //A double X is needed for temporary keeping XInitial in the next condition.
            double X;
            //A double curve is needed for calculation the lenght of the curve. 
            double curve;
            //This condition overwrites the XInitial and XFinal if the user entered from the wrong.
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
        /// <summary>
        /// This method calculations perimeter of the curved trapezoid.
        /// </summary>
        /// <param name="XInitial"></param>
        /// <param name="XFinal"></param>
        public void FigurePerimeter(double XInitial, double XFinal)
        {
            //A double X is needed for temporary keeping XInitial in the next condition.
            double X;
            //A double curve is needed for calculation the lenght of the curve. 
            double curve;
            //A double P is needed for calculation the perimeter of the curved trapezoid.
            double P;
            //This condition overwrites the XInitial and XFinal if the user entered from the wrong.
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
        /// <summary>
        /// This method calculations square of the curved trapezoid.
        /// </summary>
        /// <param name="XInitial"></param>
        /// <param name="XFinal"></param>
        public void FigureSquare(double XInitial, double XFinal)
        {
            //A double P is needed for calculation the perimeter of the curved trapezoid.
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
        /// <summary>
        /// This method checks if a given point belongs to a given trapezoid.
        /// </summary>
        /// <remarks>
        /// Coordinates are also entered in this method and checked
        /// for a valid character.
        /// </remarks>
        /// <param name="XInitial"></param>
        /// <param name="XFinal"></param>
        public void PointOwnershipCheck(double XInitial, double XFinal)
        {
            //A double X is x-axis coordinate of a point.
            double X;
            //A double Y is y-axis coordinate of a point.
            double Y;
            //A double YInitial is point y relative to the initial value of x.
            //YInitial = XInitial^2 because curved trapezoid given by a parabola.
            double YInitial = Math.Pow(XInitial, 2);
            //A double YFinal is point y relative to the final value of x.
            //YFinal = XFinal^2 because curved trapezoid given by a parabola.
            double YFinal = Math.Pow(XFinal, 2);
            Console.WriteLine("Enter X coordinate: ");
            //Checking of X for a valid character .
            while (!Double.TryParse(Console.ReadLine(), out X))
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Enter X coordinate: ");
            }
            Console.WriteLine("Enter Y coordinate: ");
            //Checking of Y for a valid character.
            while (!Double.TryParse(Console.ReadLine(), out Y))
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Enter Y coordinate: ");
            }
            //Condition whether the given point lies on the border of the figure.
            if (((X == XInitial) && (Y <= YInitial)) || ((X == XFinal) && (Y <= YFinal)) || (Y - 0.5 * Math.Pow(X, 2) == 0))
            {
                Console.WriteLine("Lies on the border of the figure.");
            }
            //Condition whether the given point belongs to a given figure.
            else if ((X > XInitial) && (X < XFinal) && (Y > 0) && (Y < YFinal) && (Y - 0.5 * Math.Pow(X, 2) < 0))
            {
                Console.WriteLine("Belongs to a given figure.");
            }
            //If the previous conditions are not made, the point does not belong to a given figure
            else
            {
                Console.WriteLine("Does not belong to a given figure.");
            }
        }
    }
}
