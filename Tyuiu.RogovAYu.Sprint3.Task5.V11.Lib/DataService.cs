﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task5.V11.Lib
{
    public class DataService : ISprint3Task5V11
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k =  startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Sin(k) + (x / 2);
                }
                sum += sum;
            }
            return sum;
        }
    }
}
