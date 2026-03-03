using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSystem.Domain
{
    public interface IShape
    {
        double CalculateArea();
        string Name { get; }
    }
}
