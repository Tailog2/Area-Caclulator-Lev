using System;

namespace Area_Caclulator
{
    public class Triangle : IShape
    {
        private IShape triangle;

        public Triangle(double a, double b, double c)
        {
            triangle = new RendomTriangle(a, b, c);
        }

        public Triangle(double legA, double legB)
        {
            triangle = new RightTriangle(legA, legB);
        }

        public double CalculateArea()
        {
            return triangle.CalculateArea();
        }

        private class RightTriangle : IShape
        {
            private double _legA;
            private double _legB;

            public RightTriangle(double legA, double legB)
            {
                _legA = legA;
                _legB = legB;
            }

            public double CalculateArea()
            {
                if (_legA <= 0 || _legB <= 0)
                    throw new Exception("Invalid input");

                return _legA * _legB / 2;
            }
        }

        private class RendomTriangle : IShape
        {
            private double _a;
            private double _b;
            private double _c;

            public RendomTriangle(double a, double b, double c)
            {
                _a = a;
                _b = b;
                _c = c;
            }

            public double CalculateArea()
            {
                if (_a <= 0 || _b <= 0 || _c <= 0)
                    throw new Exception("Invalid input");

                double temp = (_a + _b + _c) / 2;
                temp = temp * (temp - _a) * (temp - _b) * (temp - _c);
                return Math.Sqrt(temp);
            }
        }
    }
}
