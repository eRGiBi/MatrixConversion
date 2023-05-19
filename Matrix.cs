using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixConversion
{
    public class Matrix
    {
        private string[,] matrix;
        public int NumberOfCloumns { get; private set; }
        public int NumberOfRows { get; private set; }

        public Matrix(string[,] matrix, int numberOfCloumns, int numberOfRows)
        {
            this.matrix = matrix;
            NumberOfCloumns = numberOfCloumns;
            NumberOfRows = numberOfRows;
        }
       // public int this[string index1, string index2] => matrix[int.Parse(index1), int.Parse(index2)];

        public string getByDimensions(int index1, int index2)
        {
            return matrix[index1, index2];
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < NumberOfRows; i++)
            {
                
                for (int j = 0; j < NumberOfCloumns; j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
        public string[] getFirstRow()
        {
            string[] firstRow = new string[NumberOfCloumns];

            for (int i = 0; i < NumberOfRows; i++)
            {
                firstRow.Append(matrix[0,i]);
            }
            return firstRow;
            
        }
        public string[] getFirstColumn()
        {
            string[] firstCloumn = new string[NumberOfRows];

            for (int i = 0; i < NumberOfRows; i++)
            {
                firstCloumn.Append(matrix[i, 0]);
            }
            return firstCloumn;
        }      
    }
}
