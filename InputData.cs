using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementPrinting
{
    public class InputData
    {
        public double[,] Matrix { get; set; }
        public string Path { get; set; }
        public InputData(string path)
        {
            Path = path;
            GetElementInfo();
        }

        void GetElementInfo()
        {
            int LengthOfString;
            string[] Strings = File.ReadAllLines(Path);
            LengthOfString = Strings[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Count(); //Возможно заменить на int
            Matrix = new double[Strings.Length, LengthOfString];
            for (int i = 0; i < Strings.Length; i++)
            {
                double[] row = Strings[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                for (int j = 0; j < LengthOfString; j++)
                {
                    Matrix[i, j] = row[j];
                }
            }
        }
    }
}
