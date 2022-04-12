using Area_Caclulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator_Test
{
    class Square : IShape
    {
        private double _side;
        public Square(double side)
        {
            _side = side;
        }

        public double CalculateArea()
        {
            if (_side <= 0)
                throw new Exception("Invalid input");

            return Math.Pow(_side, 2);
        }
    }
}
