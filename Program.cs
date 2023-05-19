using System.Collections.Generic;
using System.IO;

namespace MatrixConversion {

    public class Program
    {            
        private static void Main(string[] args)
        {           
            FileReader fileReader = new FileReader();
            FileWriter fileWriter = new FileWriter();
            MatrixCreator matrixCreator = new MatrixCreator();

            List<Matrix> mainList = new List<Matrix>();
            List<string[]> firstMatrix = new List<string[]>();
            List<string[]> secondMatrix = new List<string[]>();
            List<string[]> thirdMatrix = new List<string[]>();

            string[] fileEntries = Directory.GetFiles(@"..\\..\\..\\CSV\");


            mainList.AddRange(fileReader.ReadFiles(fileEntries));
         
            firstMatrix.AddRange(matrixCreator.CreateFirstMatrix(mainList));

            fileWriter.WriteFile(firstMatrix, @"..\\..\\..\\Data\fm.csv");

    
            secondMatrix.AddRange(matrixCreator.CreateSecondMatrix(firstMatrix));

            fileWriter.WriteFile(secondMatrix, @"..\\..\\..\\Data\sm.csv");

     
            thirdMatrix.AddRange(matrixCreator.CreateThirdMatrix(secondMatrix));

            fileWriter.WriteFile(thirdMatrix, @"..\\..\\..\\Data\tm.csv");          
        }        
    }    
}


    