using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Caclulator
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            if (_radius <= 0)
                throw new Exception("Invalid input");

            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
