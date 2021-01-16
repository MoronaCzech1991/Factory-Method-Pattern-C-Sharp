using FactoryMethodApplication.Shapes.Algebra;

namespace FactoryMethodApplication.Shapes.Topologic
{
    public abstract class AbstractCircle
    {
        protected Point centerPoint;

        protected Vector3D radius;

        public Point GetCenter()
        {
            return centerPoint;
        }
        public Vector3D GetRadius()
        {
            return radius;
        }
        public void SetCenter(Point point)
        {
            centerPoint = point;
        }
        public void SetRadius(Vector3D vector)
        {
            radius = vector;
        }
    }
}
