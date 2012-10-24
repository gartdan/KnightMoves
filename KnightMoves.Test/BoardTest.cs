using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using KnightMoves;

namespace KnightMoves.Test
{
    /// <summary>
    /// Summary description for BoardTest
    /// </summary>
    [TestClass]
    public class BoardTest
    {
        public BoardTest()
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
        public void test_get_position()
        {
            Board b = new Board();
            BoardPosition position = b.GetPosition(Key.A);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);

            position = b.GetPosition(Key.H);
            Assert.AreEqual(2, position.X);
            Assert.AreEqual(1, position.Y);

            position = b.GetPosition(Key.N1);

            Assert.AreEqual(1, position.X);
            Assert.AreEqual(3, position.Y);
            
        }

        [TestMethod]
        public void test_get_key()
        {
            Board b = new Board();
            Key k = b.GetKey(new BoardPosition() { X = 0, Y = 0 });
            Assert.AreEqual(k, Key.A);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPositionException))]
        public void test_invalid_position_throws_exception()
        {
            Board b = new Board();
            b.GetKey(new BoardPosition() { X = -5, Y = 1000 });
        }

        [TestMethod]
        public void test_get_possible_moves()
        {
            Board b = new Board();
            var strategy = new KnightMoveStrategy(b);
            var results = strategy.GetPossibleMoves(Key.H);
            Assert.AreEqual(6, results.Count);

            results = strategy.GetPossibleMoves(Key.A);
            Assert.AreEqual(2, results.Count);

        }
    }
}
