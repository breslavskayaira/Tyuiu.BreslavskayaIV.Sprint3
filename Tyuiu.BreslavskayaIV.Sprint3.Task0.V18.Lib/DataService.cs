using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task0.V18.Lib
{
    public class DataService: ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double Mul = 1;
            int i;
            int x = value;
            for (i = startValue; i<= stopValue; i++)
            {
                Mul = Mul * (Math.Pow(2 / ((Math.Cos(x) + 0.5)), i));
            }

            return Math.Round(Mul, 3);
        }
    }
}
