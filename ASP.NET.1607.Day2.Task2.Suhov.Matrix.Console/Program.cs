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
            System.Console.WriteLine("Original matrix");
            System.Console.WriteLine(matrix.ToString());
            matrixValues[0][0] = 11111111;
            System.Console.WriteLine("Changed value from property");
            System.Console.WriteLine(matrix.ToString());
            matrix.Sort(Matrix.CompareMaxNoAsc);
            System.Console.WriteLine("Sorted matrix with defined sorting logic");
            System.Console.WriteLine(matrix.ToString());

            #region Old implementation
            System.Console.WriteLine(matrix.ToString());
            IComparer compare = new CompareMaxNoAsc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.ToString());
            compare = new CompareMaxNoDesc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.ToString());
            compare = new CompareMinNoAsc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.ToString());
            compare = new CompareMinNoDesc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.ToString());
            compare = new CompareSumNoAsc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.ToString());
            compare = new CompareSumNoDesc(matrix.GetMatrix);
            matrix.Sort(compare);
            System.Console.WriteLine(matrix.ToString());
            #endregion
            System.Console.ReadLine();
        }
    }
}
