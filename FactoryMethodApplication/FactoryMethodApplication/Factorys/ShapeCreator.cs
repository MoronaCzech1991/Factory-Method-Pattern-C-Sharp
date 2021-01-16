using FactoryMethodApplication.Shapes;
using System;

namespace FactoryMethodApplication.Factorys
{
    public class ShapeCreator : IFactoryShape
    {
        public IShape CreateShape(EShape typeShape)
        {
            switch (typeShape) 
            {
                case EShape.POINT:
                    Console.WriteLine("Point created");
                    return new Point();
                case EShape.LINE:
                    Console.WriteLine("Line created");
                    return new Line();
                case EShape.ARC:
                    Console.WriteLine("Arc created");
                    return new Arc();
                case EShape.CIRCLE:
                    Console.WriteLine("Circle created");
                    return new Circle();
                case EShape.ELLIPSE:
                    Console.WriteLine("Ellipse created");
                    return new Ellipse();
                case EShape.NURB:
                    Console.WriteLine("Nurb created");
                    return new Nurb();
                default:
                    Console.WriteLine("Default Point created");
                    return new Point();
            }
        }
    }
}
