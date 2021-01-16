namespace FactoryMethodApplication.Shapes
{
    public class Ellipse : IShape
    {
        public Ellipse() 
        {
            initialPoint = new Point();
            middleAngle = 0.0;
            controlPoint = new Point();
            finalPoint = new Point();
        }
        public Ellipse(Point initialPointValue,
                       double middleAngleValue,
                       Point controlPointValue,
                       Point finalPointvalue)
        {
            initialPoint = initialPointValue;
            middleAngle = middleAngleValue;
            controlPoint = controlPointValue;
            finalPoint = finalPointvalue;
        }

        private Point initialPoint;

        private double middleAngle;

        private Point controlPoint;

        private Point finalPoint;

        private Point GetInitialPoint() 
        {
            return initialPoint;
        }
        private double GetMiddleAngle() 
        {
            return middleAngle;
        }
        private Point GetControlPoint() 
        {
            return controlPoint;
        }
        private Point GetFinalPoint() 
        {
            return finalPoint;
        }
        private void SetInitialPoint(Point point)
        {
            initialPoint = point;
        }
        private void SetMiddleAngle(double angleValue)
        {
            middleAngle = angleValue;
        }
        private void SetControlPoint(Point point)
        {
            controlPoint = point;
        }
        private void SetFinalPoint(Point point)
        {
            finalPoint = point;
        }
    }
}
