namespace Shapes.Models
{
    public class ShapeInfo
    {
        public double CircleArea { get; set; }

        public double TriangleArea { get; set; }

        public bool IsTriangleRightAngled { get; set; }

        public ShapeInfo(double circleArea, double triangleArea, bool isTriangleRightAngled)
        {
            CircleArea = circleArea;
            TriangleArea = triangleArea;
            IsTriangleRightAngled = isTriangleRightAngled;
        }
    }
}
