namespace FactoryMethodApplication.Shapes
{
    public class Point : IShape
    {
        public Point() 
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }
        public Point(double positionX, double positionY, double positionZ)
        {
            x = positionX;
            y = positionY;
            z = positionZ;
        }

        private double x;

        private double y;

        private double z;
        public double GetX() 
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public double GetZ()
        {
            return z;
        }
        public void SetX(double position)
        {
            x = position;
        }
        public void SetY(double position)
        {
            y = position;
        }
        public void SetZ(double position)
        {
            z = position;
        }
    }
}
