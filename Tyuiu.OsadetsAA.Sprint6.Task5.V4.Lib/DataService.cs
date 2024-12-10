﻿using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.OsadetsAA.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            numsArray = numsArray.Where(val => val % 1 == 0).ToArray();
            return numsArray;
        }
    }
}
