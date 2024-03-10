namespace ShapeCalcService.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-12)]
        [InlineData(0)]
        public void Triangle_InvalidSecondSide_ThrowArgument_OutOfRangeException(double side) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, side, 20));

        [Theory]
        [InlineData(-12)]
        [InlineData(0)]
        public void Triangle_InvalidThirdSide_ThrowArgument_OutOfRangeException(double side) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(10, 20, side));

        [Theory]
        [InlineData(-12)]
        [InlineData(0)]
        public void Triangle_InvalidFirstSide_ThrowArgument_OutOfRangeException(double side) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(side, 20, 10));

        [Theory]
        [InlineData(30, 20, 10)]
        [InlineData(35, 20, 10)]
        public void Triangle_TiangleDoesnotExist_ThrowArgumentException(double firstSide,
            double secondSide, double thirdSide) =>
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));

        [Fact]
        public void CalculateArea_ValidSides_Calculate()
        {
            Assert.Equal(64.99230723708769, new Triangle(10, 20, 14).CalculateArea());

            Assert.Equal(68.08926996957749, new Triangle(10.5, 20.7, 14.14).CalculateArea());

            Assert.Equal(6, new Triangle(3, 4, 5).CalculateArea());

            Assert.Equal(7.1568040178560155, new Triangle(3.2, 4.5, 5.8).CalculateArea());
        }

        [Fact]
        public void IsTriangleRightAngled_ValidSides_IsRightAngled()
        {
            Assert.True(new Triangle(3, 4, 5).IsTriangleRightAngled());

            Assert.False(new Triangle(10, 20, 14).IsTriangleRightAngled());

            Assert.False(new Triangle(10.5, 20.2, 14.75).IsTriangleRightAngled());
        }


    }
}
