
namespace TreeDataStructure
{
    public class Tree
    {


        public Node? Root { get; private set; }

        public void AddChild(Node parent, int value)    
        {

            Node childe = new Node(value);
            childe.Parent = parent;
            parent.Children.Add(childe);
   
        }

        public void AddRoot(int value) 
        {
            Root = new Node(value);
        }

        public void FindParent(Node child) 
        { }

        public void Print()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty !!");
            }
            else
            {
                Print_Structure(Root, "|_");
            }
        }

        private void Print_Structure(Node node, string prefix)
        {
            Console.WriteLine($"{prefix}{node.Value}");
            prefix = "  " + prefix;

            for (int i = 0; i < node.Children.Count; i++)
            {
                Print_Structure(node.Children[i], prefix);
            }
        }

        public void Remove(Node nood) 
        { }
    }
}
