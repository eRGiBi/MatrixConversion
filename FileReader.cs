using MatrixConversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixConversion
{
    internal class FileReader
    {
        public List<Matrix> mainList = new List<Matrix>();

        public List<Matrix> ReadFiles(string[] fileEntries) {
          
            foreach (string fileName in fileEntries)
            {
                StreamReader streamReader = new StreamReader(fileName);

                int X = getArrayX(fileName);
                int Y = getArrayY(fileName);

                string[,] matrix = new string[X + 1, Y + 1];

                int rowCounter = 0;

                while (!streamReader.EndOfStream)
                {               
                    string? line = streamReader.ReadLine();
                
                    if (line != null)
                    {
                        string[] lineArray = line.Split(',');
                 
                        for (int i = 0; i < Y+1; i++)
                        {
                            matrix[rowCounter, i] = lineArray[i];
                        }
                    }
                    rowCounter++;                
                }
                streamReader.Close();

                mainList.Add(new Matrix(matrix, Y, X));                  
            }
            return mainList;
        }

        private static int getArrayX(string filename)
        {
            if (filename[filename.IndexOf("CSV") + 4] == ('D'))
            {
                return 44;
            }
            if (filename[filename.IndexOf("CSV") + 4] == ('E'))
            {
                return 57;
            }
            if (filename[filename.IndexOf("CSV") + 4] == ('I'))
            {
                return 45;
            }
            if (filename[filename.IndexOf("CSV") + 4] == ('M'))
            {
                return 90;
            }
            else { return 0; }

        }
        private static int getArrayY(string filename)
        {
            if (filename[filename.Length - 5] == ('H'))
            {
                return 44;
            }
            if (filename[filename.Length - 5] == ('Z'))
            {
                return 57;
            }
            if (filename[filename.Length - 5] == ('V'))
            {
                return 45;
            }
            if (filename[filename.Length - 5] == ('T'))
            {
                return 90;
            }
            else { return 0; }
        }
    }
}
