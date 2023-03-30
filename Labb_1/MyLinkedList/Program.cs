namespace MyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyLinkedList testList = new MyLinkedList();

            testList.AddNodeToStart(new MyNode(1));
            testList.AddNodeToStart(new MyNode(2));
            testList.AddNodeToStart(new MyNode(3));
            testList.AddNodeToStart(new MyNode(4));
            testList.AddNodeToStart(new MyNode(5));
            testList.AddNodeToEnd(new MyNode(6));

            testList.FlushList();

            MyNode test = testList.GetNodeAttIndex(0);
            Console.WriteLine(test.Value);



           

            Console.WriteLine("Hej Hopp Gummi Snopp!!");




        }
    }
}