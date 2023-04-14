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
            testList.AddToEnd(new Person("Stina", "Gren", 198403037003));
            testList.AddToEnd(new Person("Björn", "Granit", 198504047404));
            testList.AddToEnd(new Person("Bo", "Hallberg", 198606067606));
            testList.AddToEnd(new Person("Rolf", "Berg", 199010127138));

            //Acess item at given index
            showList(testList);

            Console.WriteLine("Add at index 5");
            testList.AddAtIndex(new Person("Alf", "Salt", 200001017141),5);

            //Acess item at given index
            showList(testList);

            //Delete a item in the list on a given index
            Console.WriteLine("Delete at index 5");
            testList.DeleteAtIndex(5);

            //Acess item at given index
            showList(testList);

            Console.WriteLine("Delete at index 0");
            testList.DeleteAtIndex(0);

            //Acess item at given index
            showList(testList);

            Console.WriteLine("Delete at index 2");
            testList.DeleteAtIndex(2);

            //Acess item at given index
            showList(testList);

            Console.WriteLine("Delete at index 3");
            testList.DeleteAtIndex(3);

            //Acess item at given index
            showList(testList);

            //Epty the list
            Console.WriteLine("Delete all");
            testList.FlushList();

            //Acess item at given index
            showList(testList);
        }

        public static void showList(IListInterface<Person> list)
        {
            Console.WriteLine("The lists contence: ");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Items in list: {list.Length}\n");

            Console.WriteLine($"\n");

        }
    }
}