using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0.0;
            
            while  (startValue <= stopValue)
            {
                sum = sum + Math.Sin(startValue)*0.5;
                startValue++;
            }

            return Math.Round(sum, 3);
        }
    }
}
