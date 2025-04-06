using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Exercises.Ex_10_ObjProKlassen
{
    static class AreaCalculator
    {
        public static double getRectangleArea(double height, double width)
        {
            return height * width;
        }
        public static double getSquareArea(double sideLengh)
        {
            return sideLengh * sideLengh;
        }
        public static double getCircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }
        public static double getTriangleArea(double sideLengh, double height)
        {
            return (sideLengh * height) / 2;
        }
    }
}
