using System;

namespace Task2
{
    public delegate string AreaCircleMessage(string message);
    public delegate double AreaCirc(double area);

    public class Circle
    {
        private const double pi = 3.141593;
        AreaCircleMessage areaCircleMessage;
        AreaCirc areaCircle;

        public void RegisterArea(AreaCirc del)
        {
            areaCircle = del;
        }

        public void RegisterAreaMessage(AreaCircleMessage del)
        {
            areaCircleMessage = del;
        }

        public void RadiusOutput(double radius)
        {
            if (radius > 0 & radius != null)
            {
                double area = GettingAreaByRadius(radius);
                areaCircle.Invoke(area);
            }
            else
            {
                areaCircleMessage.Invoke("Недопустимое значение радиуса");
            }
        }

        public double GettingAreaByRadius(double radius)
        {
            return Math.Round(pi * Math.Pow(radius, 2.0), 6);
        }
    }
}
