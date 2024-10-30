using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res=1;
            int i = startValue;
            while (i <= stopValue)
            {
                res*=Math.Pow((0.5+(i /5.0))/(Math.Cos(value)+0.5),3);
                i++;
            }
            return Math.Round(res,2);
        }
    }
}
    