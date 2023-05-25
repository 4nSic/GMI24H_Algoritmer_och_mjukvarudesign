namespace TreeDataStructure
{
    public class Node
    {
        private List<Node>  _children;

        public Node(int value)
        {
            Value = value;
            _children = new List<Node>();
        }

        public List<Node> Children {  get { return _children; }  set { _children = value; } }
        
        public Node? Parent { get; set; }

        public int Value { get; set; }

 

    }
}