using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task2.Suhov.Matrix
{
    public class CompareMinNoAsc : IComparer
    {
        private int _ix;
        private int _iy;
        // maintain a reference to the 2-dimensional array being sorted
        private int[][] sortArray;
    /// <summary> 
    /// Default constructor, initialize variables with default values 
    /// </summary> 
        public CompareMinNoAsc() { }
     /// <summary> 
     /// Constructor with parameters, initialize variables with the parameters value 
     /// </summary> 
        public CompareMinNoAsc(int[][] theArray)
        {
            sortArray = theArray;
        }
    /// <summary>
    /// Compare two Min values in jagged array in different rows
    /// </summary>
        public int Compare(object x, object y)
        {
            if (x == null || y == null || !(x is int) || !(y is int)) throw new ArgumentException(String.Format("{0}, {1} is not an int values", x, y));
            if (sortArray[_ix] == null) throw new ArgumentException(String.Format("{0} has no values inside, please run constructor with parameters", sortArray[_ix]));
                _ix = (int)x;
                _iy = (int)y;
            if (sortArray[_ix].Min() >= sortArray[_iy].Min())
                return 1;
            else
                return -1;
        }
    }
}
