using ShapeAreaLibrary.Factories;
using ShapeAreaLibrary.Shapes;

namespace ShapeAreaLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = ShapeFactory.CreateCircle(5);
            Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void RightTriangleTest()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.True(((Triangle)triangle).IsRightTriangle());
        }

        [Fact]
        public void InvalidCircleTest()
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(-5));
        }

        [Fact]
        public void InvalidTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(1, 1, 10));
        }
    }
}