using System.Collections.Generic;

namespace FactoryMethodApplication.Shapes
{
    public class Nurb : IShape
    {
        public Nurb() 
        {
            controlPoints = new List<Point>();
            knotVector = new List<double>();
            degree = 1;
        }
        public Nurb(List<Point> points, List<double> knots, int degreeValue) 
        {
            controlPoints = points;
            knotVector = knots;
            degree = degreeValue == 0 ? 1 : degreeValue;
        }

        private List<Point> controlPoints;

        private List<double> knotVector;

        private int degree;

        public List<Point> GetControlPoints() 
        {
            return controlPoints;
        }
        public List<double> GetKnotVector()
        {
            return knotVector;
        }
        public int GetDegree()
        {
            return degree;
        }
        public void GetControlPoints(List<Point> points)
        {
            controlPoints = points;
        }
        public void GetKnotVector(List<double> knots)
        {
            knotVector = knots;
        }
        public void GetDegree(int degreeValue)
        {
            degree = degreeValue;
        }
    }
}
