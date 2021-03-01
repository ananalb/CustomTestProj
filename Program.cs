using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customlist1 = new CustomList<int>();
            CustomList<int> customlist2 = new CustomList<int>();
            customlist1.AddMethod(1);
            customlist1.AddMethod(3);
            customlist1.AddMethod(5);
            customlist2.AddMethod(2);
            customlist2.AddMethod(4);
            customlist2.AddMethod(6);
            //customlist2.AddMethod(7);

            CustomList<int> result =  CustomList<int>.Zip(customlist1, customlist2);





        }
    }
}
