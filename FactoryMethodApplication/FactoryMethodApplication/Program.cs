using FactoryMethodApplication.Factorys;
using FactoryMethodApplication.Shapes;
using System;
using System.Collections.Generic;

namespace FactoryMethodApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> entities = new List<IShape>();

            IFactoryShape shapeCreator = new ShapeCreator();
            entities.Add(shapeCreator.CreateShape(EShape.POINT));
            entities.Add(shapeCreator.CreateShape(EShape.LINE));
            entities.Add(shapeCreator.CreateShape(EShape.CIRCLE));
            entities.Add(shapeCreator.CreateShape(EShape.ARC));
            entities.Add(shapeCreator.CreateShape(EShape.ELLIPSE));
            entities.Add(shapeCreator.CreateShape(EShape.NURB));

            Console.WriteLine("Factory Method.");
            Console.ReadKey();
        }
    }
}
