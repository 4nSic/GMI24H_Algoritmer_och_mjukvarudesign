using Labb6;
using TreeDataStructure;

namespace TestProject1
{
    public class TestTree
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTreeAddRoot()
        {

            //Arrange
            var root = new Tree();
            var actutal = root.AddRoot(1);
            var expected = root.Root;

            //Assert & Act
            Assert.That(actutal, Is.EqualTo(expected));
        }

        [Test]
        public void TestTreeAddChild()
        {

            //Arrange                       
            var tree = new Tree();
            var root = tree.AddRoot(1);           
            var firstChild = tree.AddChild(root, 3);
            var secondChild = tree.AddChild(root, 6);
            var children = tree.Root.Children;

            //Assert & Act
            Assert.That(children.Contains(firstChild)&& children.Contains(secondChild));
        }

        [Test]
        public void TestTreeAddChildExcepiton()
        {

            //Arrange                       
            var tree = new Tree();

            //Assert & Act
            Assert.Throws<ArgumentNullException>(() => tree.AddChild(tree.Root, 3));
        }


        [Test]
        public void TestTreeFindParent()
        {

            //Arrange
            var tree = new Tree();
            var root = tree.AddRoot(1);
            var actual = tree.FindParent(root);
            Node expected = null;

            //Assert & Act
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestTreeRemove()
        {

            //Arrange
            var tree = new Tree();
            var root = tree.AddRoot(1);
            var firstChild = tree.AddChild(root, 3);
            var secondChild = tree.AddChild(root, 6);

            //Act
            tree.Remove(secondChild);

            //Assert
            Assert.That(!root.Children.Contains(secondChild));
        }
    }
}