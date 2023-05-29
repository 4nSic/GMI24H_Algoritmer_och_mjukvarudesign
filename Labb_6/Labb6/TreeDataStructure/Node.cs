namespace TreeDataStructure
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Children = new List<Node>();
        }

        public List<Node> Children { get; set; }

        public Node? Parent { get; set; }

        public int Value { get; set; }

 

    }
}