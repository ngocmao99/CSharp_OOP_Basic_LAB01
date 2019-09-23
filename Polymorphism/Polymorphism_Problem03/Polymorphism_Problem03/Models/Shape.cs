using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Problem03.Models
{
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing";
        }
    }
}
