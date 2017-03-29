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
        private int CountForWhite(Coordinate start, Coordinate finish)
        {
            if (finish.X + finish.Y >= start.X + start.Y &&
                finish.X - finish.Y <= start.X - start.Y &&
                finish.Y >= start.Y)
                return Math.Abs(finish.Y - start.Y);
            else
                throw new ArgumentException("Not reachable field");
        }
        /// <summary>
        /// Return steps count for black
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        private int CountForBlack(Coordinate start, Coordinate finish)
        {
            if (finish.X + finish.Y <= start.X + start.Y &&
                finish.X - finish.Y >= start.X - start.Y &&
                finish.Y <= start.Y)
                return Math.Abs(finish.Y - start.Y);
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
        public int Count(char color, Coordinate start, Coordinate finish)
        {
            if (color == 'w')
                return CountForWhite(start, finish);
            else
                return CountForBlack(start, finish);
        }
    }
}
