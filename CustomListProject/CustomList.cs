using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>

    {
        private int size;
        private int buffer;
        private T[] items;
        public CustomList()
        {
            size = 0;
            buffer = 8;
            items = new T[buffer];
        }
        public void Add(T item)
        {
            T[] tempItems = new T[size+buffer];
            for (int i = 0; i < size; i++)
            {
                tempItems[i] = items[i];
            }
            tempItems[size] = item;
            items = tempItems;
            size++;
        }
        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (items[i].Equals(item))
                    index = i;
            }
            return index;
        }
        public void Remove(T item)
        {
            int index = IndexOf(item);
            while (index >= 0)
            {
                RemoveAt(index);
                index = IndexOf(item);
            }
        }
        public void RemoveAt(int index)
        {
            if(index >= 0 && index < size)
            {
                for (int i = index; i < size; i++)
                {
                    items[i] = items[i + 1];             
                }
                size--;
            }
        }
        public int Count()
        {
            return size;
        }
        public T ReturnAt(int index)
        {
            return items[index];
        }
        public override string ToString()
        {
            StringBuilder itemsStringList = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                itemsStringList.Append(items[i]);
            }
            return itemsStringList.ToString();
        }
        public void Zipper(CustomList<T> List2)
        {
            T[] tempItems = new T[size + List2.size + buffer];
            if (size >= List2.size)
            {
                for (int i = 0; i < List2.size; i++)
                {
                    tempItems[i*2] = items[i];
                    tempItems[(i*2)+1] = List2.items[i];
                }
                for (int i = List2.size*2; i < size+List2.size; i++)
                {
                    tempItems[i] = items[i-List2.size];
                }
            } 
            else if (List2.size > size)
            {
                for (int i = 0; i < size; i++)
                {
                    tempItems[i*2] = items[i];
                    tempItems[(i*2)+1] = List2.items[i];
                }
                for (int i = size*2; i < List2.size+size; i++)
                {
                    tempItems[i] = List2.items[i-size];
                }
            }
            items = tempItems;
        }
    }
}
