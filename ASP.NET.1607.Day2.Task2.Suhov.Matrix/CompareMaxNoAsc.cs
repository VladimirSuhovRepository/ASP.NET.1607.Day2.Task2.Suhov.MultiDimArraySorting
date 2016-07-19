using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task2.Suhov.Matrix
{
    public class CompareMaxNoAsc : IComparer
    {
        private int _ix;
        private int _iy;
        // maintain a reference to the 2-dimensional array being sorted
        private int[][] sortArray;
        // constructor initializes the sortArray reference
        public CompareMaxNoAsc() { }
        public CompareMaxNoAsc(int[][] theArray)
        {
            sortArray = theArray;
        }
        public int Compare(object x, object y)
        {
            if (x == null || y == null || !(x is int) || !(y is int)) throw new ArgumentException(String.Format("{0}, {1} is not an int values", x, y));
            if (sortArray[_ix] == null) throw new ArgumentException(String.Format("{0} has no values inside, please run constructor with parameters", sortArray[_ix]));
            _ix = (int)x;
            _iy = (int)y;
            if (sortArray[_ix].Max() >= sortArray[_iy].Max())
                return 1;
            else
                return -1;
        }
    }
}
