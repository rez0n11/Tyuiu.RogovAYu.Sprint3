using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue-startValue+1] ;
            int i = 0;
            while (i < res.Length)
            {
                if (startValue+i == 0) { res[0] = 0; i++; continue; }
                res[i] = F(i);
                i++;
            }
            return res ;
        }
        public double F(int x)
        {
            return (Math.Cos(2 * x) + 2 * x + (Math.Sin(x)) / (x + 2.5));
        }
    }
}
