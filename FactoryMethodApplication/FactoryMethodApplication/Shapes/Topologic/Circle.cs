using FactoryMethodApplication.Shapes.Algebra;
using FactoryMethodApplication.Shapes.Topologic;

namespace FactoryMethodApplication.Shapes
{
    public class Circle : AbstractCircle, IShape
    {
        public Circle() 
        {
            centerPoint = new Point();
            radius = new Vector3D();
        }
        public Circle(Point centerPointPosition, Vector3D radiusVector)
        {
            centerPoint = centerPointPosition;
            radius = radiusVector;
        }
    }
}
