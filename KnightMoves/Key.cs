using System;

namespace KnightMoves
{
    public class Key
    {
        public static readonly Key Invalid = new Key("X");
        public static readonly Key A = new Key("A");
        public static readonly Key B = new Key("B");
        public static readonly Key C = new Key("C");
        public static readonly Key D = new Key("D");
        public static readonly Key E = new Key("E");
        public static readonly Key F = new Key("F");
        public static readonly Key G = new Key("G");
        public static readonly Key H = new Key("H");
        public static readonly Key I = new Key("I");
        public static readonly Key J = new Key("J");
        public static readonly Key K = new Key("K");
        public static readonly Key L = new Key("L");
        public static readonly Key M = new Key("M");
        public static readonly Key N = new Key("N");
        public static readonly Key O = new Key("O");
        public static readonly Key N1 = new Key("1");
        public static readonly Key N2 = new Key("2");
        public static readonly Key N3 = new Key("3");

        public static readonly Key[] Vowels = { Key.A, Key.E, Key.I, Key.O };
        public static readonly Key[] AllKeys = 
        {
            Key.A,
            Key.B,
            Key.C,
            Key.D,
            Key.E,
            Key.F,
            Key.G, 
            Key.H,
            Key.I,
            Key.J,
            Key.K,
            Key.L,
            Key.M,
            Key.N,
            Key.O,
            Key.N1,
            Key.N2,
            Key.N3
        };

        public string Name { get; protected set; }

        public Key(string name)
        {
            this.Name = name;
        }
        
        public bool IsVowel()
        {
            foreach (Key vowel in Vowels)
                if (vowel == this)
                    return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            Key rhs = obj as Key;
            if (rhs == null)
                return false;
            return this.Name == rhs.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
