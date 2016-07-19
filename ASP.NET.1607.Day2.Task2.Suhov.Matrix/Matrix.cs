using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task2.Suhov.Matrix
{
    public class Matrix
    {
        private int _rowNum;
        private int _colNum;
        private int[][] _matrix;
        private int[] _matrixSubArray;
        public int[][] GetMatrix { get { return _matrix; } }
        public string GetMatrixString { get { return GetOutputStringArray(); } }
        public Matrix() { }
        public Matrix(int rowNum, int colNum)
        {
            _rowNum = rowNum;
            _colNum = colNum;
            FillMatrix();
            FillSubArray();
        }
        public void Sort(IComparer comparison)
        {
            Array.Sort(_matrixSubArray, comparison);
            for (int i = 0; i < _matrixSubArray.Length; i++)
            {
                _matrix[i] = _matrix[_matrixSubArray[i]];
            }
        }
        private void FillSubArray()
        {
            _matrixSubArray = new int[_rowNum];
            for (int i = 0; i < _rowNum; i++)
            {
                _matrixSubArray[i] = i;
            }
        }
        private void FillMatrix()
        {
            var num = new System.Random();
            _matrix = new int[_rowNum][];
            for (int i = 0; i < _rowNum; i++)
            {
                int[] item = new int[_colNum];
                for (int ii = 0; ii < _colNum; ii++)
                {
                    item[ii] = num.Next(1, 10);
                }
                _matrix[i] = item;
            }
        }
        private string GetOutputStringArray()
        {
            var result = new StringBuilder();
            for (int i = 0; i < _matrix.Length; i++)
            {
                for (int ii = 0; ii < _matrix[i].Length; ii++)
                {
                    result.Append(" " + _matrix[i][ii]);
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }
        

    }

}
