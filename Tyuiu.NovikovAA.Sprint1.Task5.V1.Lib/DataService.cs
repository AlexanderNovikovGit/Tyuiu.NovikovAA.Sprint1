using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovAA.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task1V5
    {
        public double Calculate(double x, double y)
        {
            return Convert.ToInt32(Math.Abs(x - y));
        }
    }
}
