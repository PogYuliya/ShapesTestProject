namespace ShapeCalcService.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-12)]
        [InlineData(-100)]
        [InlineData(0)]
        public void Circle_InvalidRadius_ThrowsArgumentOutOfRangeException(double radius) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));


        [Fact]
        public void CalculateArea_ValidRadius_Calculate()
        {
            Assert.Equal(452.3893421169302, new Circle(12).CalculateArea());
            Assert.Equal(31415.926535897932, new Circle(100).CalculateArea());
            Assert.Equal(506.7074790974977, new Circle(12.7).CalculateArea());
        }
    }
}
