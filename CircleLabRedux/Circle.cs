using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLabRedux
{
    class Circle
    {
        public double Radius {get; set;}
        
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle()
        {
        }

        //public override string ToString()
        //{
        //    string output = $"Radius: {Math.Round(Radius,2)}\n" +
        //        $"Circumference: {Math.Round(Circumference,2)}\n" +
        //        $"Area: {Math.Round(Area,2)}";
        //    return output;
        //}
        public double CalculateCircumference(double radius)
        {
            double circumference = radius * Math.PI * 2;
            return Math.Round(circumference, 2);
        }
        public double CalculateArea()
        {
            return Area;
        }
        
    }
}
