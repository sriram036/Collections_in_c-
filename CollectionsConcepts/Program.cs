using System;


namespace CollectionsConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GenericType genericType = new GenericType();

            // Generic List
            genericType.InsertData(50);
            genericType.InsertData(20);
            genericType.InsertData(70);
            genericType.ShowList();
            Console.WriteLine();

            NonGenericType nonGenericType = new NonGenericType();

            // Non Generic List
            nonGenericType.InsertData();
            nonGenericType.ShowList();
        }
    }
}
