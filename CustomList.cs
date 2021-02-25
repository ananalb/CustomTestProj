using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListUnitTestProj
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {

            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }


        public void AddMethod(T itemToAdd)
        {

            if (count == capacity)
            {

                T[] newArray = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {

                    newArray[i] = items[i];

                }
                items = newArray;
            }
            items[count] = itemToAdd;
            count++;

        }

        public void RemoveMethod(T itemToRemove)
        {

            T[] newArray = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    j--;
                    count--;
                }
                else
                {
                    newArray[j] = items[i];
                }
            }
            items = newArray;

        }

        public override string ToString()
        {
            string Finalstring = "";
            for (int i = 0; i < count; i++)
            {

                Finalstring += items[i].ToString();


            }
            return Finalstring;
        }

        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> customList = new CustomList<T>();
            for (int i = 0; i < one.Count; i++)
            {
                customList.AddMethod(one[i]);

            }
            for (int i = 0; i < two.Count; i++)
            {
                customList.AddMethod(two[i]);
            }

            return customList;
        }

        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {

            CustomList<T> customList = new CustomList<T>();

            for (int i = 0; i < one.count; i++)
            {
                for (int j = 0; j < two.count; j++)
                {
                    if (one[i].Equals(two[j]))
                    {
                        customList.RemoveMethod(one[i]);
                    }
                }
            }

            for (int i = 0; i < two.count; i++)
            {
                for (int j = 0; j < one.count; j++)
                {
                    if (two[i].Equals(one[j]))
                    {
                        customList.RemoveMethod(two[i]);
                    }
                }

            }
            return customList;
        }
    }

 }





        //    public IEnumerable GetEnumerator()
        //    {

        //        for (int index = 0; index < items.Count; index++)
        //        {
        //            yield return items[i];

        //        }
        //        yield return "";

        //    }

        //}
    
    

