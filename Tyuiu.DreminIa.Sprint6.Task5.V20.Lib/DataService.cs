using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint6.Task5.V20.Lib
{
    public class DataService : ISprint6Task5V20
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader rdr = new StreamReader(path))
            {
                string line;
                while ((line = rdr.ReadLine()) != null) 
                {
                    double y = Convert.ToDouble(line);
                    if (y % 2 == 0)
                    {
                        len++;
                    }
                }
            }
            double[] arr = new double[len];
            int ind = 0;
            using (StreamReader rdr = new StreamReader(path))
            {
                string line;
                while ((line = rdr.ReadLine()) != null) 
                {
                    double y = Convert.ToDouble(line);
                    if (y % 2 == 0)
                    {
                        arr[ind] = y;
                        ind++;
                    }
                }

            }
            return arr;
        }
    }
}
