using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightMoves
{
    public class SequenceGenerator
    {
        protected Board _board;
        protected IMoveStrategy _moveStrategy;
        protected int _pathSize;
        
        public SequenceGenerator(Board board, IMoveStrategy moveStrategy, int pathSize)
        {
            _board = board;
            _moveStrategy = moveStrategy;
            _pathSize = pathSize;
        }

        public int CountAllSequences()
        {
            int sum = 0;
            foreach (Key key in Key.AllKeys)
            {
                sum += CountSequencesFromKey(key, _board.KeyPress(key, new KeypadSequence()));
            }
            return sum;
        }

        public int CountSequencesFromKey(Key key, KeypadSequence sequence)
        {
            if (!sequence.IsValidSequence())
                return 0;
            if (sequence.Length == _pathSize)
                return 1;
            int count = 0;
            var possibleMoves = this._moveStrategy.GetPossibleMoves(key);
            foreach (var move in possibleMoves)
                count += CountSequencesFromKey(move, _board.KeyPress(move, new KeypadSequence(sequence)));
            return count;
        }
    }
}
