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
        #region Private fields
        private int[][] _matrix;
        private int[] _matrixSubArray;
        #endregion
        /// <summary>
        /// Return multidimentional array with matrix inside
        /// </summary>
        public int[][] GetMatrix { get { return CopyArray(); } }
        /// <summary>
        /// Return multidimentional array as a string
        /// </summary>
        public override string ToString()
        {
            return GetOutputStringArray();
        }
        /// <summary>
        /// Default constructor, initialize variables with default values
        /// </summary>
        public Matrix() { }
        /// <summary>
        /// Constructor with parameters, initialize variables with the parameters value
        /// </summary>
        public Matrix(int rowNum, int colNum)
        {
            FillMatrix(rowNum, colNum);
            FillSubArray();
        }
        /// <summary>
        /// Delegate which used for sorting method to pass two arrays inside
        /// </summary>
        public delegate int CompareRows(int[] array1, int[] array2);
        /// <summary>
        /// Sort matrix with required comparer
        /// </summary>
        public void Sort(CompareRows Compare)
        {
            if (_matrix == null)
                throw new ArgumentNullException(nameof(_matrix));
            if (Compare == null)
                throw new ArgumentNullException(nameof(Compare));
            for (int i = _matrix.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Compare(_matrix[j], _matrix[j + 1]) > 0)
                    {
                        Swap(ref _matrix[j], ref _matrix[j + 1]);
                    }
                }
            }
        }
        /// <summary>
        /// The comparer method for sorting delegate
        /// </summary>
        public static int CompareMaxNoAsc(int[] array1, int[] array2)
        {
            if (array1.Max() >= array2.Max())
                return 1;
            else
                return -1;
        }
        /// <summary>
        /// Sort matrix with required comparison
        /// </summary>
        public void Sort(IComparer comparison)
        {
            Array.Sort(_matrixSubArray, comparison);
            for (int i = 0; i < _matrixSubArray.Length; i++)
            {
                _matrix[i] = _matrix[_matrixSubArray[i]];
            }
        }
        #region Private methods
        private void FillSubArray()
        {
            _matrixSubArray = new int[_matrix.Length];
            for (int i = 0; i < _matrix.Length; i++)
            {
                _matrixSubArray[i] = i;
            }
        }
        private void FillMatrix(int rowNum, int colNum)
        {
            var num = new System.Random();
            _matrix = new int[rowNum][];
            for (int i = 0; i < rowNum; i++)
            {
                int[] item = new int[colNum];
                for (int ii = 0; ii < colNum; ii++)
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
        private int[][] CopyArray()
        {
            int[][] result=new int[_matrix.Length][];
            for (int i = 0; i < _matrix.Length; i++)
            {
                int[] item = new int[_matrix[i].Length];
                for (int ii = 0; ii < _matrix[i].Length; ii++)
                {
                    item[ii] = _matrix[i][ii];
                }
                result[i] = item;
            }
            return result;
        }
        private void Swap(ref int[] firstArray, ref int[] secondArray)
        {
            int[] bufferArray = firstArray;
            firstArray = secondArray;
            secondArray = bufferArray;
        }
        #endregion

    }

}
