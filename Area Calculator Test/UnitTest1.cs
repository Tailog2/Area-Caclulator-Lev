using Area_Caclulator;
using System;
using Xunit;

namespace Area_Calculator_Test
{    

    public class UnitTest1
    {
        AreaCaclulator areaCaclulator = new AreaCaclulator();

        IShape rightTriangle = new Triangle(4, 6);
        IShape rendomTriangle = new Triangle(4, 5, 3);
        IShape square = new Square(5);
        IShape invalidSquare = new Square(-5);

        IShape circle = new Circle(6);
        double expectedCircleArea = Math.PI * 6 * 6;

        [Fact]
        public void CalculateArea_rightTriangle_ShouldReturn12()
        {
            
            double area = areaCaclulator.CalculateArea(rightTriangle);
            Assert.Equal(12, area);
        }

        [Fact]
        public void CalculateArea_rendomTriangle_ShouldReturn6()
        {
            double area = areaCaclulator.CalculateArea(rendomTriangle);
            Assert.Equal(6, area);
        }

        [Fact]
        public void CalculateArea_circle_ShouldReturn6()
        {
            double area = areaCaclulator.CalculateArea(circle);
            Assert.Equal(expectedCircleArea, area);
        }

        [Fact]
        public void CalculateArea_square_CalculateArea_circle_ShouldReturn25()
        {
            double area = areaCaclulator.CalculateArea(square);
            Assert.Equal(25, area);
        }

        [Fact]
        public void CalculateArea_invalidSquare_ThrowExeption()
        {
            Assert.Throws<Exception>(() => areaCaclulator.CalculateArea(invalidSquare));
        }
    }
}
