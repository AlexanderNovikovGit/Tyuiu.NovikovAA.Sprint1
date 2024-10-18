using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovAA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double answer = 0;
            answer = (1 + Math.Sin(Math.Sqrt(x * x + 1)) / Math.Cos(12 * y - 4));
            return Math.Round(answer, 3);
        }
    }
}
