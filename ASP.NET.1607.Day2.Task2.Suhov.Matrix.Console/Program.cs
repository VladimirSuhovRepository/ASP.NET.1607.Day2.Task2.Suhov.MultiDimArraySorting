using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task2.Suhov.Matrix.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(4,5);
            int[][] matrixValues=matrix.GetMatrix;
            System.Console.WriteLine(matrix.GetMatrixString);
            IComparer compare = new CompareMaxNoAsc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.GetMatrixString);
            compare = new CompareMaxNoDesc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.GetMatrixString);
            compare = new CompareMinNoAsc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.GetMatrixString);
            compare = new CompareMinNoDesc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.GetMatrixString);
            compare = new CompareSumNoAsc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.GetMatrixString);
            compare = new CompareSumNoDesc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.GetMatrixString);
            System.Console.ReadLine();
        }
    }
}
