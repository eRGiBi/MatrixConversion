using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MatrixConversion
{
    public class MatrixCreator
    {
        public List<string[]> firstMatrix = new();
        public List<string[]> secondMatrix = new();
        public List<string[]> thirdMatrix = new();

        public List<string[]> CreateFirstMatrix(List<Matrix> mainList)
        {
            foreach (Matrix matrix in mainList)
            {
                for (int i = 0; i < matrix.NumberOfRows; i++)
                {
                    for (int j = 0; j < matrix.NumberOfCloumns; j++)
                    {
                        string[] line = new string[3];
                        line[0] = matrix.getByDimensions(i + 1, 0);
                        
                        line[1] = matrix.getByDimensions(0, j + 1);
                        
                        line[2] = matrix.getByDimensions(i + 1, j + 1);
                        
                        firstMatrix.Add(line);
                    }
                }
            }
            return firstMatrix;
        }

        public List<string[]> CreateSecondMatrix(List<string[]> firstmatrix)
        {
            foreach (string[] line in firstmatrix)
            {
                string[] newLine = new string[4];
                            
                newLine[0] = line[0];
                newLine[1] = line[1];
                newLine[2] = line[2];
                newLine[3] = GetReverse(line, firstmatrix);

                secondMatrix.Add(newLine);
            }
            return secondMatrix;
        }

        private static string GetReverse(string[] line, List<string[]> matrix)
        {
            string target = "";
            foreach (string[] matrixLine in matrix)
            {               
                if (matrixLine[0].Equals(line[1]) && matrixLine[1].Equals(line[0]))
                {
                    target = matrixLine[2];
                    break;
                }
            }
            return target;
        }

        public List<string[]> CreateThirdMatrix(List<string[]> secondMatrix)
        {           
            foreach (string[] line in secondMatrix)
            {
                string[] newLine = new string[4];

                if (!CheckList(line, thirdMatrix))
                {
                    newLine[0] = line[0];
                    newLine[1] = line[1];
                    newLine[2] = line[2];
                    newLine[3] = line[3];
                    
                    thirdMatrix.Add(newLine);                  
                }
            }
            return thirdMatrix;
        }

        private static bool CheckList(string[] line, List<string[]> matrix)
        {
            bool HasIt = false;
            foreach(string[] matrixLine in matrix)
            {              
               if (matrixLine[0].Equals(line[1]) && matrixLine[1].Equals(line[0]))
                {
                    HasIt = true;
                    break;
                }
            }
            return HasIt; 
        }
    }
}          
  


