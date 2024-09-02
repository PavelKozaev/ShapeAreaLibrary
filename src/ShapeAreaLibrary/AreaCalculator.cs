using ShapeAreaLibrary.Shapes;

namespace ShapeAreaLibrary
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
