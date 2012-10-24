using System;
using System.Collections.Generic;

namespace KnightMoves
{
    public class KeypadSequence
    {
        protected List<Key> _keySequence = new List<Key>();

        public KeypadSequence()
        {
        }

        public KeypadSequence(KeypadSequence copy)
        {
            _keySequence.AddRange(copy.Keys);
        }

        public KeypadSequence Add(Key key)
        {
            _keySequence.Add(key);
            return this;
        }

        public IList<Key> Keys
        {
            get { return _keySequence; }
        }

        public int Length
        {
            get { return this._keySequence.Count; }
        }

        public bool IsValidSequence()
        {
            return GetNumVowels() <= 2;
        }

        public int GetNumVowels()
        {
            int numVowels = 0;
            foreach (var key in _keySequence)
                if (key.IsVowel())
                    numVowels++;
            return numVowels;
        }
    }
}
