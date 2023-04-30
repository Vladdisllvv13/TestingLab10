

using System;


namespace MathTaskClassLibrary1
{
    public class Geometry
    {
        public double CylinderArea(double r, double h)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 4);
        }
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
