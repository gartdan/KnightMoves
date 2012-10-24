using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightMoves
{
    public class BoardPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return string.Format("X: {0}, Y:{1}", X.ToString(), Y.ToString());
        }
    }
}
