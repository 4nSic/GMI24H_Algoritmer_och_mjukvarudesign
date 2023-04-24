namespace HashTabelsTests
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
            Assert.Pass();
        }

        [TestCase(0)]
        public void Test2(int value) 
        {
            Assert.Pass();
        }
    }
}