﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanovSV.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int value)
        {
            return Math.Round(value / 39.37, 3);
        }
    }
}