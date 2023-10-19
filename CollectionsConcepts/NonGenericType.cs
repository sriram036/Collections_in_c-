using System;
using System.Collections;

namespace CollectionsConcepts
{
    public class NonGenericType
    {
        ArrayList list = new ArrayList();

        public NonGenericType()
        {
        }

        public void InsertData()
        {
            list.Add(100);
            list.Add("Sriram");
            list.Add(100.55F);
            list.Add(true);
        }

        public void ShowList()
        {
            foreach (var data in list)
            {
                Console.Write(data + " ");
            }
        }
    }
}
