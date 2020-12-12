using System;
using StructureAlgorithms.Algorithms;
using StructureAlgorithms.Structure;

namespace StructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.element = 5;
            list.next = new LinkedList<int>()
            {
                element = 6,
                from = list
            };

            list.next.next = new LinkedList<int>()
            {
                element = 7,
                from = list.next,
                next = list
            };


            //Console.WriteLine(list.element);
            //Console.WriteLine(list.next.element);
            //Console.WriteLine(list.next.next.element);
            //Console.WriteLine(list.next.next.next.element);
            //Console.WriteLine(list.next.next.next.next.element);
            //Console.WriteLine(list.next.next.next.next.next.element);


            int[] mas1 = new int[] { 3,7,11,90,4,1,2,8,9};
            int[] mas13 = Sort.SelectingSort(mas1);
            foreach (var a in mas13)
            {
                Console.WriteLine(a);
            }

            //var index = Search.binarySearch(mas1, 7);
            //Console.WriteLine(index);

            //double[] mas2 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //index = Search.binarySearch(mas2, 8);
            //Console.WriteLine(index);


            Console.ReadKey();

        }
    }
}
