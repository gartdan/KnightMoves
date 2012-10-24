using System;

namespace KnightMoves
{
    [global::System.Serializable]
    public class InvalidPositionException : Exception
    {
        public InvalidPositionException() { }
        public InvalidPositionException(string message) : base(message) { }
        public InvalidPositionException(string message, Exception inner) : base(message, inner) { }
        protected InvalidPositionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [global::System.Serializable]
    public class KeyNotFoundOnBoardException : Exception
    {
        public KeyNotFoundOnBoardException() { }
        public KeyNotFoundOnBoardException(string message) : base(message) { }
        public KeyNotFoundOnBoardException(string message, Exception inner) : base(message, inner) { }
        protected KeyNotFoundOnBoardException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
