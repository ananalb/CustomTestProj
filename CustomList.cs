using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListUnitTestProj
{
    public class CustomList <T>
    {
        public T[] items;
        public int count;
        public int capacity;

        public CustomList()
        {
           
          count = 0;
          capacity = 4;
          items = new T[capacity];
            
        }
        public void AddMethod(T itemToAdd)
        {
           
            if (count == capacity)
            {
                //create new  array
                T[] newArray = new T[capacity];
                //move items over
                T[] oldArray = items;
                for(int i = 0; i < newArray.Length; i++ )
                {
                    oldArray[count] = itemToAdd;
                    itemToAdd = newArray[capacity * 2];
                }
                                                                                                         
            }
            items[count] = itemToAdd;
            count++;

        }

        public void RemoveMethod(T itemToRemove)
        {
            if (count > capacity)
            {
                //create new  array
                T[] newArray = new T[8];
                //move items over         
                //new array is now _items array.
            }
            items[count] = itemToRemove;
            count--;
        }

        public void StringMethod(T itemToAdd)
        {
            if (count > capacity)
            {
                //create new  array
                T[] newArray = new T[8];
                //move items over

                items[1].Equals(newArray[1]);
                items[2].Equals(newArray[2]);
                items[3].Equals(newArray[3]);


                //new array is now _items array.
            }
            items[count] = itemToAdd;
            count++;
        }
    }
}
