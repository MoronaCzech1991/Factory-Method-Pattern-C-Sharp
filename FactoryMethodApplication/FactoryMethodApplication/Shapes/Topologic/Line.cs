using System;

namespace FactoryMethodApplication.Shapes
{
    public class Line : IShape
    {
        public Line() 
        {
            initialPoint = new Point();
            finalPoint = new Point();
        }
        public Line(Point pointOne, Point pointTwo)
        {
            initialPoint = pointOne;
            finalPoint = pointTwo;
        }
        public Line(double initialPositionX,
                    double initialPositionY,
                    double initialPositionZ,
                    double finalPositionX,
                    double finalPositionY,
                    double finalPositionZ)
        {
            initialPoint = new Point(initialPositionX, initialPositionY, initialPositionZ);
            finalPoint = new Point(finalPositionX, finalPositionY, finalPositionZ);
        }

        private Point initialPoint;

        private Point finalPoint;
        public Point GetInitialPoint() 
        {
            return initialPoint;
        }
        public Point GetFinalPoint()
        {
            return finalPoint;
        }
        public void SetInitialPoint(Point point)
        {
            initialPoint = point;
        }
        public void SetFinalPoint(Point point)
        {
            finalPoint = point;
        }
        private double CalculateDistance() 
        {
            double distanceX = Math.Pow(finalPoint.GetX() - initialPoint.GetX(), 2);
            double distanceY = Math.Pow(finalPoint.GetY() - initialPoint.GetY(), 2);
            double distanceZ = Math.Pow(finalPoint.GetZ() - initialPoint.GetZ(), 2);

            return Math.Sqrt(distanceX + distanceY + distanceZ);
        }
    }
}
