using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace CustomListUnitTestProj
{
    public class CustomList<T> : IEnumerable
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


        public void Add(T itemToAdd)
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

        public bool Remove(T itemToRemove)
        {

            T[] newArray = new T[capacity];
            bool isRemoved = false;
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    j--;
                    isRemoved = true;

                }
                else
                {
                    newArray[j] = items[i];
                }
            }
            items = newArray;
            if (isRemoved == true)
            {
                count--;
            }
            return isRemoved;

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
                customList.Add(one[i]);

            }
            for (int i = 0; i < two.Count; i++)
            {
                customList.Add(two[i]);
            }

            return customList;
        }

        public static CustomList<T> operator -(CustomList<T> baseList, CustomList<T> itemsToRemove)
        {
            CustomList<T> resultList = new CustomList<T>();
            for (int i = 0; i < baseList.count; i++)
            {
                resultList.Add(baseList[i]);
            }

            for (int i = 0; i < itemsToRemove.count; i++)
            {
                resultList.Remove(itemsToRemove[i]);               
            }

            return resultList;

        }



        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {

            CustomList<T> listThree = new CustomList<T>();
            if (listOne.count >= listTwo.count)
                for (int i = 0; i < listOne.count; i++)
                {
                    listThree.Add(listOne[i]);
                    if (i < listTwo.count)
                    {
                        listThree.Add(listTwo[i]);
                    }
                }
            else
            {             
                for (int i = 0; i < listTwo.count; i++)
                {
                    listThree.Add(listTwo[i]);
                    if (i < listOne.count)
                    {
                        listThree.Add(listOne[i]);
                    }
                }
            }
            return listThree;
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

       

    }
}





