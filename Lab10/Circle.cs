using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double Radius;

        public Circle (double radius)
        {
            Radius = radius;
        }

        public double CalculcateCircumference()
        {
            return (2 * Math.PI * Radius); 
        }

        public double CalculateArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        private string FormatNumber(double x)
        {
            //formats from double to string with 2 decimals
            return $"{x, 0:F2}";
        }

        public string CalculateFormattedCircumference()
        {
            //converts double Circumference to a string with 2 decimal places
            return FormatNumber(CalculcateCircumference());
        }

        public string CalculcateFormattedArea()
        {
            //converts double Circumference to a string with 2 decimal places
            return FormatNumber(CalculateArea());
        }
    }
}
