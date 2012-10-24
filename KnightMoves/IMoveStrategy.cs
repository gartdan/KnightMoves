using System;
using System.Collections.Generic;

namespace KnightMoves
{
    public interface IMoveStrategy
    {
        IList<Key> GetPossibleMoves(Key key);
    }
}
