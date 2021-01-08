using NUnit.Framework;
using TernaryEmulator;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Trit s = new Trit(0);
            Trit d = new Trit(1);
            Trit f = new Trit(2);

            Trit a = new Trit(3);
            Trit b = new Trit(4);
            Trit c = new Trit(5);
            
            
            Assert.AreEqual(c, b + a);
        }
    }
}