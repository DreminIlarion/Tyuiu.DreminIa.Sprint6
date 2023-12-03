using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GurevskayaVE.Sprint6.Task2.V11.Lib
{
    public class DataService : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((Math.Cos(x)) / (x + 1)) - 1.3 * Math.Cos(x) + 3 * x;
                y = Math.Round(y, 2);
                valueArray[4] = 0;
                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}
