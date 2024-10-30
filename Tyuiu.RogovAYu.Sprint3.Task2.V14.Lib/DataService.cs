using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int x, int k, int m)
        {
            double res = 1;
            do {res*= Math.Pow((Convert.ToDouble(x) / Convert.ToDouble(k)), 3); k++; } while (k <= m);
            return Math.Round(res,3);
        }
    }
}
