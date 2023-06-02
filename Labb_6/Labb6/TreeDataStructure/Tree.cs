
namespace TreeDataStructure
{
    /// <summary>
    /// Publica klass träd
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// 
        /// </summary>
        public Node? Root { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
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

        /// <summary>
        /// Adderar ett löv i vårat träd 
        /// </summary>
        /// <param name="parent">Lövets förälder node</param>
        /// <param name="value">Lövets data</param>
        /// <returns>Returnerar lövet som är skapat</returns>
        /// <exception cref="ArgumentNullException">Kastas om föräldern är tom </exception>
        /// <exception cref="InvalidOperationException">Kastas om föräldern redan har 2 löv</exception>
        public Node AddChild(Node parent, int value)    
        {
            if (parent == null) throw new ArgumentNullException("The parent cannot be null");
            else if (parent.Children.Count >= 2) throw new InvalidOperationException("The parent cannot cant hold more then two children.");
            else 
            {
                Node childe = new Node(value);
                childe.Parent = parent;
                parent.Children.Add(childe);
                return childe;
            }
        }

        /// <summary>
        /// Returnerar nodens förälder
        /// </summary>
        /// <param name="child">Lövets vars förälder vi söker</param>
        /// <returns>Returnerar den sökta föräldern</returns>
        public Node FindParent(Node child) 
        {
            return child.Parent;
        }

        /// <summary>
        /// Skriver ut om null empty, om det finns ett träd visualizerar den det
        /// </summary>
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

        /// <summary>
        /// Visualizerar trädet
        /// </summary>
        /// <param name="node">Föräldern</param>
        /// <param name="prefix">Tecknet som är visulatizon</param>
        private void Print_Structure(Node node, string prefix)
        {
            Console.WriteLine($"{prefix}"+" |_"+$"{node.Value}");
            prefix = "  " + prefix;

            for (int i = 0; i < node.Children.Count; i++)
            {
                Print_Structure(node.Children[i], prefix);
            }
        }

        /// <summary>
        /// Tar bort den nod du vill tar bort
        /// </summary>
        /// <param name="node">Det man vill ta bort?=</param>
        /// <exception cref="ArgumentNullException">Kastar om noden är tom</exception>
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
