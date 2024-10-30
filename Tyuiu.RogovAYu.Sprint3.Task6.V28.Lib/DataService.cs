using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            int i = 0;
            while (startValue<=stopValue)
            {
                while (i<7) 
                {
                    if (startValue%(i+1)==0) { res++;}
                    i++;
                }
                i = 0; startValue++;
            }
            return res;
        }
    }
}
