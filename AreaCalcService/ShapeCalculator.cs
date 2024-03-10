namespace ShapeCalcService
{
    public class ShapeCalculator : IShapeCalculator
    {
        public double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }

        public bool IsTriangleRightAngled(Triangle triangle)
        {
            return triangle.IsTriangleRightAngled();
        }
    }
}
