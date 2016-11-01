using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : CollectionBase, IEnumerable, IComparer

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
        public T this[int index]
        {
            get
            {
                return (T)this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }
        public new IEnumerator GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return items[i];
            }
        }
        public int Compare(object first, object second)
        {
            return (new CaseInsensitiveComparer()).Compare(second, first);
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
        public new void RemoveAt(int index)
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
        public new int Count()
        {
            return size;
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
        public CustomList<T> Zipper(CustomList<T> zipperList)
        {
            CustomList<T> list = new CustomList<T>();
            if (size >= zipperList.size)
            {
                for (int i = 0; i < zipperList.size; i++)
                {
                    list.Add(items[i]);
                    list.Add(zipperList[i]);
                }
            } 
            else if (zipperList.size > size)
            {
                for (int i = 0; i < size; i++)
                {
                    list.Add(items[i]);
                    list.Add(zipperList[i]);
                }
            }
            return list;
        }
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> list = new CustomList<T>();
            for (int i = 0; i < firstList.size; i++)
            {
                list.Add(firstList.items[i]);
            }
            for (int i = 0; i < secondList.size; i++)
            {
                list.Add(secondList[i]);
            }   
            return list;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            for (int i = 0; i < secondList.size; i++)
            {
                firstList.Remove(secondList[i]);
            }
            return firstList;
        }
    }
}
