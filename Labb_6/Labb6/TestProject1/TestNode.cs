using Labb6;
using TreeDataStructure;

namespace TestProject1

{
    public class TestNode
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNodeValue()
        {
            //Arrange
            int expectedInt = 7;
            var test = new Node(expectedInt);
     
            //Act
            int actual = test.Value;

            //Assert
            Assert.That(actual, Is.EqualTo(expectedInt));
        }

        [Test]
        public void TestNodeChildren()
        {
            //Arrange
            List<Node> expected = new List<Node>();
            var test = new Node(0);

            //Act
            var actual = test.Children;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestNodeParent()
        {
            //Arrange
            Node parent = new Node(0);
            Node test = new Node(1);

            //Act
            test.Parent = parent;   
            var actual = test.Parent;
      

            //Assert
            Assert.That(actual, Is.EqualTo(parent));
        }

    }
}