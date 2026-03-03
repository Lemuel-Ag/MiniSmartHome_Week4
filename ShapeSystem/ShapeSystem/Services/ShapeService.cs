using ShapeSystem.Domain;
using ShapeSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSystem.Services
{
    public class ShapeService
    {
        private readonly ILogger _logger;

        public ShapeService(ILogger logger)
        {
            _logger = logger;
        }

        public void Process(IShape shape)
        {
            double area = shape.CalculateArea();
            string report = $"{DateTime.Now}: {shape.Name} Area = {area}";
            _logger.Log(report);
        }
    }
}
