using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res=1;
            while (startValue <= stopValue)
            {
                res*=(0.5+startValue/5)/(Math.Cos(value)+.5);
                startValue++;
            }
            return Math.Round(Math.Pow(res,3),3);
        }
    }
}
