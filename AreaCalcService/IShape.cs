namespace ShapeCalcService
{
    public interface IShape
    {
        public string ShapeName { get; }

        public double CalculateArea();
    }
}
