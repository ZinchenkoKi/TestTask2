using System;

namespace Task2
{
    public class Triangle
    {

        public delegate string AreaCTriangleMessage(string message);
        public delegate double AreaTriangle(double area);

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

        public void Area(double first, double second, double third)
        {
            if (CheckPossibilityExistenceTriangle(first, second, third))
            {
                double area = GettingAreaTriangle(first, second, third);
                areaCircle.Invoke(area);
            }
            else
            {
                areaCircleMessage.Invoke("Такого треугольника не существует!");
            }
        }

        public double GettingAreaTriangle(double first, double second, double third)
        {
            double halfMeter = (first + second + third) / 2;
            double area = Math.Sqrt(halfMeter * (halfMeter - first) * (halfMeter - second) * (halfMeter - third));
            return area;
        }

        private bool CheckPossibilityExistenceTriangle(double first, double second, double third)
        {
            if (first + second > third && second + third > first && third + first > second)
            {
                return true;
            }
            return false;
        }
    }
}
