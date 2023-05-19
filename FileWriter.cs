using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixConversion
{
    internal class FileWriter
    {
        public void WriteFile(List<string[]> list, string fileName)
        {
            using (var file = File.CreateText(fileName))
            {
                foreach (var arr in list.ToList())
                {
                    // if (String.IsNullOrEmpty(arr)) continue;
                    file.Write(arr[0]);
                    for (int i = 1; i < arr.Length; i++)
                    {
                        file.Write(",");
                        file.Write(arr[i]);
                    }
                    file.WriteLine();
                }
                file.Close();
            }
        }
    }
}
