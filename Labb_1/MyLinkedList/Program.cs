namespace MyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyLinkedList testList = new MyLinkedList();

            testList.AddToEnd(new MyNode(new Person("Anna", "Sten", 198201017001)));
            testList.AddToEnd(new MyNode(new Person("Lina", "Al", 198002027002)));
            testList.AddToEnd(new MyNode(new Person("Stina", "Gren", 198403037003)));
            testList.AddToEnd(new MyNode(new Person("Björn", "Granit", 198504047404)));
            testList.AddToEnd(new MyNode(new Person("Bo", "Hallberg", 198606067606)));
            testList.AddToEnd(new MyNode(new Person("Rolf", "Berg", 199010127138)));

            testList.DeleteAtIndex(5);

            testList.FlushList();

            



           

            Console.WriteLine("Hej Hopp Gummi Snopp!!");




        }
    }
}