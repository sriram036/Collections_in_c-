using System;
using System.Collections.Generic;
namespace CollectionsConcepts
{
    public class GenericType
    {
        List<int> list = new List<int>();
        public GenericType()
        {
            
        }

        public void InsertData(int data)
        {
            list.Add(data);
            
        }

        public void ShowList()
        {
            list.Sort();
            foreach (int data in list)
            {
                Console.Write(data + " ");
            }
        }
    }
}
