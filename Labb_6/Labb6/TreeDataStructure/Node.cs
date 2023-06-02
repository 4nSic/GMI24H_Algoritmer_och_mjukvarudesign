namespace TreeDataStructure
{
    public class Node
    {
        /// <summary>
        /// Construktor som skapar våra Noder.
        /// </summary>
        /// <param name="value">Nodens data</param>
        public Node(int value)
        {
            Value = value;
            Children = new List<Node>();
        }

        /// <summary>
        /// Property som ger åtkomst till Nodens barn.
        /// </summary>
        public List<Node> Children { get; set; }

        /// <summary>
        /// Property som ger åtkomst till nodens föräldrar.
        /// </summary>
        public Node? Parent { get; set; }

        /// <summary>
        /// Property som ger åtkomst till nodens value/data.
        /// </summary>
        public int Value { get; set; }
    }
}