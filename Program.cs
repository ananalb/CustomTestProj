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
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 3, 7, 1 };

            CustomList<int> result = one - two;

        }
    }
}
