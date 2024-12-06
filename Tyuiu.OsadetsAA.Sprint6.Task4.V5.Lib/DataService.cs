﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.OsadetsAA.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
