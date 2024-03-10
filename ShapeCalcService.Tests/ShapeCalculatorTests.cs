namespace ShapeCalcService.Tests
{
    public class ShapeCalculatorTests
    {
        private readonly IShapeCalculator _shapeCalculator;
        public ShapeCalculatorTests() =>
            _shapeCalculator = new ShapeCalculator();

        [Fact]
        public void CalculateShapeArea_ValidCircle_CalculateCircleArea()
        {
            Assert.Equal(452.3893421169302, _shapeCalculator.CalculateShapeArea(new Circle(12)));
            Assert.Equal(31415.926535897932, _shapeCalculator.CalculateShapeArea(new Circle(100)));
            Assert.Equal(506.7074790974977, _shapeCalculator.CalculateShapeArea(new Circle(12.7)));
        }

        [Theory]
        [InlineData(-12)]
        [InlineData(0)]
        public void CalculateShapeArea_InvalidCircle_ThrowArgumentOutOfRangeException(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _shapeCalculator.CalculateShapeArea(new Circle(radius)));
            Assert.Throws<ArgumentOutOfRangeException>(() => _shapeCalculator.CalculateShapeArea(new Circle(radius)));
        }

        [Fact]
        public void CalculateShapeArea_ValidTriangle_CalculateTriangleArea()
        {
            Assert.Equal(64.99230723708769, _shapeCalculator.CalculateShapeArea(new Triangle(10, 20, 14)));

            Assert.Equal(68.08926996957749, _shapeCalculator.CalculateShapeArea(new Triangle(10.5, 20.7, 14.14)));

            Assert.Equal(6, _shapeCalculator.CalculateShapeArea(new Triangle(3, 4, 5)));

            Assert.Equal(7.1568040178560155, _shapeCalculator.CalculateShapeArea(new Triangle(3.2, 4.5, 5.8)));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-12)]
        public void CalculateShapeArea_InvalidTriangle_ThrowArgumentOutOfRangeException(double side) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => _shapeCalculator.CalculateShapeArea(new Triangle(10, side, 20)));

        [Theory]
        [InlineData(30, 20, 10)]
        [InlineData(35, 20, 10)]
        public void CalculateShapeArea_TiangleDoesnotExist_ThrowArgumentException(double firstSide,
            double secondSide, double thirdSide) =>
            Assert.Throws<ArgumentException>(() => _shapeCalculator.CalculateShapeArea(new Triangle(firstSide, secondSide, thirdSide)));

        [Fact]
        public void IsTriangleRightAngled_ValidTriangle_IsTriangleRightAngled()
        {
            Assert.True(_shapeCalculator.IsTriangleRightAngled(new Triangle(3, 4, 5)));

            Assert.False(_shapeCalculator.IsTriangleRightAngled(new Triangle(10, 20, 14)));

            Assert.False(_shapeCalculator.IsTriangleRightAngled(new Triangle(10.5, 20.2, 14.75)));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-12)]
        public void IsTriangleRightAngled_InvalidTriangle_ThrowArgumentOutOfRangeException(double side)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _shapeCalculator.IsTriangleRightAngled(new Triangle(10, side, 20)));
        }

        [Theory]
        [InlineData(30, 20, 10)]
        [InlineData(35, 20, 10)]
        public void IsTriangleRightAngled_TiangleDoesnotExist_ThrowArgumentException(double firstSide,
            double secondSide, double thirdSide) =>
            Assert.Throws<ArgumentException>(() => _shapeCalculator.IsTriangleRightAngled(new Triangle(firstSide, secondSide, thirdSide)));
    }
}
