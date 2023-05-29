
namespace TreeDataStructure
{
    public class Tree
    {
        public Node? Root { get; private set; }

        public Node AddChild(Node parent, int value)    
        {
            if (parent == null) throw new ArgumentNullException("The parent cannot be null");
            else if (parent.Children.Count >= 2) throw new InvalidOperationException("The parent cannot cant hold more then two children");
            else 
            {
                Node childe = new Node(value);
                childe.Parent = parent;
                parent.Children.Add(childe);
                return childe;
            }
        }

        public Node AddRoot(int value) 
        {
            if(Root == null)
            {
                Root = new Node(value);
                return Root;
            }
            else 
            {
                throw new InvalidOperationException("A root node already exists");
            }
        }

        public void FindParent(Node child) 
        {
            
        }

        public void Print()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty !!");
            }
            else
            {
                Print_Structure(Root, "");
            }
        }

        private void Print_Structure(Node node, string prefix)
        {
            Console.WriteLine($"{prefix}"+" |_"+$"{node.Value}");
            prefix = "  " + prefix;

            for (int i = 0; i < node.Children.Count; i++)
            {
                Print_Structure(node.Children[i], prefix);
            }
        }

        public void Remove(Node node) 
        {
            if (node == null) throw new ArgumentNullException("The node cannot be null");
            else if (node == Root)
            { 
                Root = null;
            }
            else 
            {
                node.Parent.Children.Remove(node);
                node.Parent = null;
            }            

            
        }
    }
}
