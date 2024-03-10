namespace ShapeCalcService
{
    public interface IShapeCalculator
    {
        double CalculateShapeArea(IShape shape);
        bool IsTriangleRightAngled(Triangle triangle);
    }
}
