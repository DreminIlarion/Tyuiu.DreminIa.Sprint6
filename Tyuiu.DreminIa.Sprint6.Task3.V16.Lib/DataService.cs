using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SafronovVV.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[2, i] % 2 == 0)
                {
                    matrix[2, i] = 0;
                }
            }

            return matrix;
        }
    }
}
