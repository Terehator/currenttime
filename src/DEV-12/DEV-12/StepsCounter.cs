using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_12
{
    /// <summary>
    /// Count steps
    /// </summary>
    public class StepsCounter
    {
        /// <summary>
        /// Return steps count for white
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        private int CountForWhite(Tuple<int, int> start, Tuple<int, int> finish)
        {
            if (finish.Item1 + finish.Item2 >= start.Item1 + start.Item2 &&
                finish.Item1 - finish.Item2 <= start.Item1 - start.Item2 &&
                finish.Item2 >= start.Item2)
                return Math.Abs(finish.Item2 - start.Item2);
            else
                throw new ArgumentException("Not reachable field");
        }
        /// <summary>
        /// Return steps count for black
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        private int CountForBlack(Tuple<int, int> start, Tuple<int, int> finish)
        {
            if (finish.Item1 + finish.Item2 <= start.Item1 + start.Item2 &&
                finish.Item1 - finish.Item2 >= start.Item1 - start.Item2 &&
                finish.Item2 <= start.Item2)
                return Math.Abs(finish.Item2 - start.Item2);
            else
                throw new ArgumentException("Not reachable field");
        }
        /// <summary>
        /// Count steps
        /// </summary>
        /// <param name="color"></param>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        public int Count(char color, Tuple<int, int> start, Tuple<int, int> finish)
        {
            if (color == 'w')
                return CountForWhite(start, finish);
            else
                return CountForBlack(start, finish);
        }
    }
}
