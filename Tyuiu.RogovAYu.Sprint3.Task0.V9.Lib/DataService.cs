using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double x, int a, int b)
        {
            double sum = 0;
            for (int i = a; i< b; i++)
            { sum += Math.Pow( (1 / (3 + Math.Pow(x, i))), i); }
            return Math.Round(sum,3);
        }
    }
}
