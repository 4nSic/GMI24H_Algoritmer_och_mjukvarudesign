using TreeDataStructure;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();

            myTree.AddRoot(1);


            myTree.AddChild(myTree.Root, 2);
            myTree.AddChild(myTree.Root, 2);

            myTree.AddChild(myTree.Root.Children[0], 3);
            myTree.AddChild(myTree.Root.Children[0], 3);

            myTree.AddChild(myTree.Root.Children[0].Children[0], 4);
            myTree.AddChild(myTree.Root.Children[0].Children[0], 4);

            myTree.AddChild(myTree.Root.Children[1], 3);
            myTree.AddChild(myTree.Root.Children[1], 3);

            myTree.Print();
        }
    }
}