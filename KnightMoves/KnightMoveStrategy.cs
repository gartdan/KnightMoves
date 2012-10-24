using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightMoves
{
    public class KnightMoveStrategy : IMoveStrategy
    {
        private Board _board;

        public KnightMoveStrategy(Board board)
        {
            _board = board;
        }
        
        #region IMoveStrategy Members

        public IList<Key> GetPossibleMoves(Key currentKey)
        {
            BoardPosition currentPosition = _board.GetPosition(currentKey);
            List<BoardPosition> potentialPositions = GetPotentialMoves(currentPosition);
            List<BoardPosition> validPositions = GetValidMoves(potentialPositions);
            var results = (from vp in validPositions
                           select _board.GetKey(vp)).ToList();
            return results;
        }

        private List<BoardPosition> GetValidMoves(List<BoardPosition> potentalMoves)
        {
            //List<BoardPosition> validMoves = new List<BoardPosition>();
            var validMoves = (from pm in potentalMoves
                             where _board.IsValidPosition(pm)
                             select pm).ToList();

            //foreach (var position in potentalMoves)
            //{
            //    if (_board.IsValidPosition(position))
            //        validMoves.Add(position);
            //}
            return validMoves;

        }

        private List<BoardPosition> GetPotentialMoves(BoardPosition cp)
        {
            List<BoardPosition> potentialMoves = new List<BoardPosition>();
            int CX = cp.X; //current X
            int CY = cp.Y; //current Y
            //there are 8 possible knight moves
            potentialMoves.Add(new BoardPosition() { X = CX - 1, Y = CY + 2 });
            potentialMoves.Add(new BoardPosition() { X = CX + 1, Y = CY + 2 });
            potentialMoves.Add(new BoardPosition() { X = CX - 1, Y = CY - 2 });
            potentialMoves.Add(new BoardPosition() { X = CX + 1, Y = CY - 2 });
            potentialMoves.Add(new BoardPosition() { X = CX - 2, Y = CY - 1 });
            potentialMoves.Add(new BoardPosition() { X = CX - 2, Y = CY + 1 });
            potentialMoves.Add(new BoardPosition() { X = CX + 2, Y = CY + 1 });
            potentialMoves.Add(new BoardPosition() { X = CX + 2, Y = CY - 1 });
            return potentialMoves;

        }

        #endregion
    }
}
