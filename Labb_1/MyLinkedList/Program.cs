﻿namespace MyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create an instance of the MyLinkedList class
            MyLinkedList<Person> testList = new MyLinkedList<Person>();

            //Add content to the list
            testList.AddToEnd(new Person("Anna", "Sten", 198201017001));
            testList.AddToEnd(new Person("Lina", "Al", 198002027002));
            testList.AddToStart(new Person("Stina", "Gren", 198403037003));
            testList.AddToStart(new Person("Björn", "Granit", 198504047404));
            testList.AddToEnd(new Person("Bo", "Hallberg", 198606067606));
            testList.AddToStart(new Person("Rolf", "Berg", 199010127138));

            //Write list length to the console
            Console.WriteLine($"Items in list: {testList.Length}");

            Console.WriteLine($"Value of item at index 5: {testList[5]}");

            //Delete a item in the list on a given index
            testList.DeleteAtIndex(5);

            //Write list length to the console
            Console.WriteLine($"Items in list: {testList.Length}");

            //Epty the list
            testList.FlushList();

            //Write list length to the console
            Console.WriteLine($"Items in list: {testList.Length}");
        }
    }
}