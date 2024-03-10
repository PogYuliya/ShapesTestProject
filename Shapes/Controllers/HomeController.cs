using ShapeCalcService;
using Microsoft.AspNetCore.Mvc;
using Shapes.Models;

namespace Shapes.Controllers
{
    public class HomeController:Controller
    {
        private readonly IShapeCalculator _shapeCalculator;

        public HomeController(IShapeCalculator shapeAreaCalculator)
        {
            _shapeCalculator = shapeAreaCalculator;
        }

        public IActionResult Index()
        {
            Circle circle=new(25);
            double areaCircle=_shapeCalculator.CalculateShapeArea(circle);

            Triangle triangle = new(10, 12, 10);
            double areaTriangle = _shapeCalculator.CalculateShapeArea(triangle);
            bool isTriangleRightAngled=_shapeCalculator.IsTriangleRightAngled(triangle);

            return View(new ShapeInfo(areaCircle,areaTriangle,isTriangleRightAngled));
        }
    }
}
