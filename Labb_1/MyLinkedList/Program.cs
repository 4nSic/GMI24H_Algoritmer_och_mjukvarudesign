namespace MyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create an instance of the MyLinkedList class
            IListInterface<Person> testList = new MyLinkedList<Person>();

            //Add content to the list
            testList.AddToEnd(new Person("Anna", "Sten", 198201017001));
            testList.AddToEnd(new Person("Lina", "Al", 198002027002));
            testList.AddToStart(new Person("Stina", "Gren", 198403037003));
            testList.AddToStart(new Person("Björn", "Granit", 198504047404));
            testList.AddToEnd(new Person("Bo", "Hallberg", 198606067606));
            testList.AddToStart(new Person("Rolf", "Berg", 199010127138));
            testList.AddAtIndex(new Person("Alf", "Salt", 200001017141),5);

            //Write list length to the console
              Console.WriteLine($"Items in list: {testList.Length}\n");

            //Acess item at given index
            Console.WriteLine("The lists contence: ");
             foreach (var item in testList)
            {
                Console.WriteLine($"{item}");
            }

            //Delete a item in the list on a given index
            testList.DeleteAtIndex(5);

            //Write list length to the console
            Console.WriteLine($"\nItems in list: {testList.Length}\n");

            //Epty the list
            testList.FlushList();

            //Write list length to the console
            Console.WriteLine($"Items in list: {testList.Length}");
        }
    }
}