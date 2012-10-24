using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            IMoveStrategy moveStrategy = new KnightMoveStrategy(b);
            SequenceGenerator generator = new SequenceGenerator(b, moveStrategy, 3);
            int numMoves = generator.CountAllSequences();
            Console.WriteLine(numMoves.ToString());
            //Console.ReadLine();

        }
    }
}
