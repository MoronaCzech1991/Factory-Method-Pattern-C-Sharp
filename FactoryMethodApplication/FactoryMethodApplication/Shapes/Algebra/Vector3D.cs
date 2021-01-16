namespace FactoryMethodApplication.Shapes.Algebra
{
    public class Vector3D
    {
        public Vector3D()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
            direction = EDirection.FOWARD;
        }
        public Vector3D(double positionX, 
                        double positionY, 
                        double positionZ, 
                        EDirection directionVector)
        {
            x = positionX;
            y = positionY;
            z = positionZ;
            direction = directionVector;
        }

        private double x;

        private double y;

        private double z;

        private EDirection direction;

        public double X()
        {
            return x;
        }
        public double Y()
        {
            return y;
        }
        public double Z()
        {
            return z;
        }
        public EDirection Direction() 
        {
            return direction;
        }
    }
}
