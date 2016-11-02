using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : CollectionBase, IEnumerable where T : IComparable<T>

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
        public void Remove(T item)
        {
            int index = GetIndexOf(item);
            while (index >= 0)
            {
                RemoveAt(index);
                index = GetIndexOf(item);
            }
        }
        private int GetIndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (items[i].Equals(item))
                    index = i;
            }
            return index;
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
                T[] tempItems = new T[size + buffer];
                for (int i = 0; i < size; i++)
                {
                    tempItems[i] = items[i];
                }
                items = tempItems;
            }
        }
        public new int Count()
        {
            return size;
        }
        public override string ToString()
        {
            StringBuilder items = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                items.Append(this.items[i]);
            }
            return items.ToString();
        }
        public CustomList<T> Zipper(CustomList<T> list)
        {
            CustomList<T> zipperedList = new CustomList<T>();
            int smallestList = Math.Min(size, list.size);
            for (int i = 0; i < smallestList; i++)
            {
                zipperedList.Add(items[i]);
                zipperedList.Add(list[i]);
            }
            return zipperedList;
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
        public void Sort()
        {
            MyQuickSort(items, 0, size);
        }
        public int CompareTo(T other)
        {
            return this.CompareTo(other);
        }
        static int MyPartition<T>(T[] list, int left, int right) where T : IComparable<T>
        {
            int start = left;
            T pivot = list[start];
            left++;
            right--;
            while (true)
            {
                while (left <= right && list[left].CompareTo(pivot) < 0)
                {
                    left++;
                }
                while (left <= right && list[right].CompareTo(pivot) > 0)
                {
                    right--;
                }
                if (left > right)
                {
                    list[start] = list[left - 1];
                    list[left - 1] = pivot;
                    return left;
                }
                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;
            }
        }
        private static void MyQuickSort(T[] list, int left, int right)
        {
            if (list == null || list.Count() <= 1)
                return;
            if (left < right)
            {
                int pivotIndex = MyPartition(list, left, right);
                MyQuickSort(list, left, pivotIndex - 1);
                MyQuickSort(list, pivotIndex, right);
            }
        }
    }
}
