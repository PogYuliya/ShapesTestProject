namespace ShapeCalcService
{
    public class Triangle : IShape
    {
        public string ShapeName { get; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(firstSide), "Triangle sides must be positive.");
            }
            if (secondSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(secondSide), "Triangle sides must be positive.");
            }
            if (thirdSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(thirdSide), "Triangle sides must be positive.");
            }
            if (firstSide + secondSide <= thirdSide || (firstSide + thirdSide) < secondSide
                || secondSide + thirdSide <= firstSide)
            {
                throw new ArgumentException("The triangle doesn`t exist.");
            }
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            ShapeName = "Triangle";
        }

        public double CalculateArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
            return area;
        }

        public bool IsTriangleRightAngled()
        {
            double[] sides = { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);
            return sides[2] * sides[2] == sides[1] * sides[1] + sides[0] * sides[0];
        }
    }
}
