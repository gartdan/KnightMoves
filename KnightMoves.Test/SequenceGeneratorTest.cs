using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using KnightMoves;

namespace KnightMoves.Test
{
    /// <summary>
    /// Summary description for SequenceGeneratorTest
    /// </summary>
    [TestClass]
    public class SequenceGeneratorTest
    {
        public SequenceGeneratorTest()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void test_count_sequences_from_key()
        {
            Board b = new Board();
            IMoveStrategy strategy = new KnightMoveStrategy(b);
            SequenceGenerator generator = new SequenceGenerator(b, strategy, 2);
            int numMoves = generator.CountSequencesFromKey(Key.A, new KeypadSequence().Add(Key.A));

            Assert.AreEqual(2, numMoves);

            numMoves = generator.CountSequencesFromKey(Key.H, new KeypadSequence().Add(Key.H));
            Assert.AreEqual(6, numMoves);

        }

        [TestMethod]
        public void test_generate_sequence_pathsize_1()
        {
            Board b = new Board();
            IMoveStrategy strategy = new KnightMoveStrategy(b);
            SequenceGenerator generator = new SequenceGenerator(b, strategy, 10);
            int count = generator.CountAllSequences();
            Assert.IsTrue(count > 0);
        }

        [TestMethod]
        public void test_sequence_with_more_than_2_vowels_is_invalid()
        {
            var sequence = new KeypadSequence();
            sequence.Add(Key.A).Add(Key.B).Add(Key.E).Add(Key.I);
            Assert.IsFalse(sequence.IsValidSequence());
        }

        [TestMethod]
        public void test_sequence_with_2_vowels_is_valid()
        {
            var sequence = new KeypadSequence();
            sequence.Add(Key.A).Add(Key.E).Add(Key.F);
            Assert.IsTrue(sequence.IsValidSequence());
        }

        [TestMethod]
        public void test_sequence_with_lessthan_2_vowels_is_valid()
        {
            var sequence = new KeypadSequence();
            sequence.Add(Key.A).Add(Key.C).Add(Key.D);
            Assert.IsTrue(sequence.IsValidSequence());
        }
    }
}
