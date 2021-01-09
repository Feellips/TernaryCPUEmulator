using System.Globalization;
using NUnit.Framework;
using TernaryEmulator;

namespace Tests
{
    public class Arithmetic
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Negation

        [Test]
        public void NegationTest1()
        {
            var actual = new Trit(-1);
            var expected = new Trit(1);

            Assert.AreEqual(expected, -actual);
        }

        [Test]
        public void NegationTest2()
        {
            var actual = new Trit(0);
            var expected = new Trit(0);

            Assert.AreEqual(expected, -actual);
        }

        [Test]
        public void NegationTest3()
        {
            var actual = new Trit(1);
            var expected = new Trit(-1);

            Assert.AreEqual(expected, -actual);
        }

        #endregion


        #region Addition

        [Test]
        public void AdditionTest1()
        {
            var a = new Trit(-1);
            var b = new Trit(-1);

            var expected = new Trit(1);

            var actual = a + b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AdditionTest2()
        {
            var a = new Trit(-1);
            var b = new Trit(0);

            var expected = new Trit(-1);

            var actual = a + b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AdditionTest3()
        {
            var a = new Trit(-1);
            var b = new Trit(-1);

            var expected = new Trit(0);

            var actual = a + b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AdditionTest4()
        {
            var a = new Trit(1);
            var b = new Trit(1);

            var expected = new Trit(-1);

            var actual = a + b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AdditionTest5()
        {
            var a = new Trit(0);
            var b = new Trit(0);

            var expected = new Trit(0);

            var actual = a + b;

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Subtraction

        public void SubtractionTest1()
        {
            var a = new Trit(-1);
            var b = new Trit(-1);

            var expected = new Trit(1);

            var actual = a - b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractionTest2()
        {
            var a = new Trit(-1);
            var b = new Trit(0);

            var expected = new Trit(-1);

            var actual = a - b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractionTest3()
        {
            var a = new Trit(-1);
            var b = new Trit(-1);

            var expected = new Trit(0);

            var actual = a - b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractionTest4()
        {
            var a = new Trit(1);
            var b = new Trit(1);

            var expected = new Trit(-1);

            var actual = a - b;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractionTest5()
        {
            var a = new Trit(0);
            var b = new Trit(0);

            var expected = new Trit(0);

            var actual = a - b;

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Multiplying

        #endregion

        #region Division

        #endregion
    }
}