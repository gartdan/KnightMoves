using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightMoves
{
    public class Board
    {
        private Key[,] board = 
        {
            { Key.A, Key.B, Key.C, Key.D, Key.E },
            { Key.F, Key.G, Key.H, Key.I, Key.J },
            { Key.K, Key.L, Key.M, Key.N, Key.O },
            { Key.Invalid, Key.N1, Key.N2, Key.N3, Key.Invalid }
        };

        public BoardPosition GetPosition(Key key)
        {
            for (int y = 0; y <= board.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= board.GetUpperBound(1); x++)
                {
                    Key k = this.GetKeyInternal(x, y);
                    if (k == key)
                        return new BoardPosition() { X = x, Y = y };
                }
            }
            throw new KeyNotFoundException("Key was not found on board: " + key.Name);
        }

        public KeypadSequence KeyPress(Key k, KeypadSequence sequence)
        {
            sequence.Add(k);
            return sequence;
        }

        public Key GetKey(BoardPosition position)
        {
            if(!IsValidPosition(position))
                throw new InvalidPositionException(position.ToString());
            return GetKeyInternal(position.X, position.Y);
        }

        protected Key GetKeyInternal(int x, int y)
        {
            return board[y, x];
        }

        public bool IsValidPosition(BoardPosition position)
        {
            if(!IsInBounds(position))
                return false;
            Key key = GetKeyInternal(position.X, position.Y);
            if (key == Key.Invalid)
                return false;
            return true;
        }

        private bool IsInBounds(BoardPosition position)
        {
            return IsValidXPosition(position.X) && IsValidYPosition(position.Y);
        }

        private bool IsValidYPosition(int y)
        {
            return y >= 0 && y <= board.GetUpperBound(0);
        }

        private bool IsValidXPosition(int x)
        {
            return x >= 0 && x <= board.GetUpperBound(1);
        }
    }

}
