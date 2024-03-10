namespace ShapeCalcService
{
    public class Circle : IShape
    {
        public string ShapeName { get; }

        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be positive.");
            }
            Radius = radius;
            ShapeName = "Circle";
        }

        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
