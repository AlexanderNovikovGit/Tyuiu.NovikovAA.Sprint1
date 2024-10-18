using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovAA.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);
            return Convert.ToInt32((Math.Sqrt(Math.Pow(distance, 2) + Math.Pow(height, 2))));
        }
    }
}
