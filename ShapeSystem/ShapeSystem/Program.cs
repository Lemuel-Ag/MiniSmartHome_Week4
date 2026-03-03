using ShapeSystem.Domain;
using ShapeSystem.Infrastructure;
using ShapeSystem.Services;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        ShapeService service = new ShapeService(logger);

        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);

        service.Process(circle);
        service.Process(rectangle);
    }
}
