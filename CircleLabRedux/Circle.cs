using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLabRedux
{
    class Circle
    {
        public double Radius {get; set;}
        public double Circumfernce => Radius * Math.PI * 2;
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override string ToString()
        {
            string output = $"Radius: {Math.Round(Radius,2)}\n" +
                $"Circumference: {Math.Round(Circumfernce,2)}\n" +
                $"Area: {Math.Round(Area,2)}";
            return output;
        }
        public double CalculateCircumference()
        {
            return Circumfernce;
        }
        public double CalculateArea()
        {
            return Area;
        }
        
    }
}
