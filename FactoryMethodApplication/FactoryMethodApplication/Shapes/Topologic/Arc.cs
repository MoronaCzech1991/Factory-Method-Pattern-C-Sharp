using FactoryMethodApplication.Shapes.Algebra;
using FactoryMethodApplication.Shapes.Topologic;

namespace FactoryMethodApplication.Shapes
{
    public class Arc : AbstractCircle, IShape
    {
        public Arc() 
        {
            centerPoint = new Point();
            radius = new Vector3D();
            middlePoint = new Point();
        }
        public Arc(Point centerPointValue, Vector3D vector, Point middlePointValue)
        {
            centerPoint = centerPointValue;
            radius = vector;
            middlePoint = middlePointValue;
        }

        private Point middlePoint;

        public Point GetMiddlePoint() 
        {
            return middlePoint;
        }
        public void SetMiddlePoint(Point point)
        {
            middlePoint = point;
        }
    }
}
