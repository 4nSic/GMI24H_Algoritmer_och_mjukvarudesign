using TreeDataStructure;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var tree = new Tree();

            tree.AddRoot(1);
            Console.WriteLine("After adding childe 2 and 3 to root 1");
            var node2 = tree.AddChild(tree.Root, 2);
            var node3 = tree.AddChild(tree.Root, 3);
            tree.Print();

            Console.WriteLine("After adding child 4 and 5 to node 2");
            var node4 = tree.AddChild(node2, 4);
            var node5 = tree.AddChild(node2, 5);
            tree.Print();

            Console.WriteLine("After adding child 6 and 7 to node 3");
            var node6 = tree.AddChild(node3, 6);
            var node7 = tree.AddChild(node3, 7);
            tree.Print();

            Console.WriteLine("After removing node2 and all it`s children");
            tree.Remove(node2);
            tree.Print();



            //Tree myTree = new Tree();

            //myTree.AddRoot(1);


            //myTree.AddChild(myTree.Root, 2);
            //myTree.AddChild(myTree.Root, 2);

            //myTree.AddChild(myTree.Root.Children[0], 3);
            //myTree.AddChild(myTree.Root.Children[0], 3);

            //myTree.AddChild(myTree.Root.Children[0].Children[0], 4);
            //myTree.AddChild(myTree.Root.Children[0].Children[0], 4);

            //myTree.AddChild(myTree.Root.Children[1], 3);
            //myTree.AddChild(myTree.Root.Children[1], 3);

            //myTree.Print();
        }
    }
}