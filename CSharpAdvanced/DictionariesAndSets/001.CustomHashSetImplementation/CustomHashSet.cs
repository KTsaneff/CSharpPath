using System;
using System.Collections.Generic;
using System.Text;

namespace _001.CustomHashSetImplementation
{
    public class CustomHashSet
    {
        int size = 5000;
        private List<string>[] internalArray;
        public CustomHashSet()
        {
            internalArray = new List<string>[size];
        }

        public void Add(string element)
        {
            int index = HashFunction(element);

            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
                internalArray[index].Add(element);
            }
            else
            {
                internalArray[index].Add(element);
            }
        }

        public bool Contains(string element)
        {
            int index = HashFunction(element);

            if (internalArray[index] != null)
            {
                for (int i = 0; i < internalArray[index].Count; i++)
                {
                    if (internalArray[index][i] == element)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private int HashFunction(string element)
        {
            int sum = 0;

            for (int i = 0; i < element.Length; i++)
            {
                sum += element[i];
            }

            return sum % size;
        }
    }
}
