using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MartysevichAD.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";

            using(StreamReader reader = new StreamReader(path))
            {
                string line;

                while((line = reader.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');
                    for (int i = 2; i < word.Length-1; i += 3)
                    {
                        res += " " + word[i];
                    }
                        
                }
            }
            return res;
        }
    }
}
