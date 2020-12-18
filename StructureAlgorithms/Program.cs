using System;
using System.Collections.Generic;
using StructureAlgorithms.Algorithms;
using StructureAlgorithms.structur;

namespace StructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //list.element = 5;
            //list.next = new LinkedList<int>()
            //{
            //    element = 6,
            //    from = list
            //};

            //list.next.next = new LinkedList<int>()
            //{
            //    element = 7,
            //    from = list.next,
            //    next = list
            //};


            //Console.WriteLine(list.element);
            //Console.WriteLine(list.next.element);
            //Console.WriteLine(list.next.next.element);
            //Console.WriteLine(list.next.next.next.element);
            //Console.WriteLine(list.next.next.next.next.element);
            //Console.WriteLine(list.next.next.next.next.next.element);


            //int[] mas1 = new int[] { 3,7,11,90,4,1,2,8,9};
            //int[] mas13 = Sort.SelectingSort(mas1);
            //foreach (var a in mas13)
            //{
            //    Console.WriteLine(a);
            //}

            //var index = Search.binarySearch(mas1, 7);
            //Console.WriteLine(index);

            //double[] mas2 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //index = Search.binarySearch(mas2, 8);
            //Console.WriteLine(index);

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(5);

            //while (!stack.isEmpty())
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //Queue<int> queue = new Queue<int>();
            //queue.Push(1);
            //queue.Push(1);
            //queue.Push(2);
            //queue.Push(3);
            //queue.Push(5);

            //while (!queue.isEmpty())
            //{
            //    Console.WriteLine(queue.Pop());
            //}

            //Console.WriteLine("start");
            //var graph = new Dictionary<int, IEnumerable<int>>();
            //graph.Add(1, new List<int>() { 2,3});
            //graph.Add(3, new List<int>() { 5,6,7 });
            //graph.Add(2, new List<int>() { 10,11,12});
            //graph.Add(6, new List<int>() { 1, 2, 3 });

            //var gs = new GraphSearch();
            //gs.widthSearch(graph, 3, 10);

            //Console.WriteLine("end");

            var gs = new GraphSearch();
            //Dictionary<Tkey, Dictionary<Tkey, double>> graph, Dictionary< Tkey, double> costs, Dictionary<Tkey, Tkey> parents

            var graph = new Dictionary<string, Dictionary<string, double>>();
            var a = new Dictionary<string, double>();
            a.Add("fin", 1);
            graph.Add("a", a);
            var b = new Dictionary<string, double>();
            b.Add("a", 3);
            b.Add("fin", 5);
            graph.Add("b", b);
            graph.Add("fin", null);

            Dictionary<string, double> costs = new Dictionary<string, double>();
            costs.Add("a",6);
            costs.Add("b", 2);
            costs.Add("fin", double.PositiveInfinity);

            Dictionary<string, string> parents = new Dictionary<string, string>();
            parents.Add("a","start");
            parents.Add("b", "start");
            parents.Add("in", null);
            Console.WriteLine("start");
            var res  = gs.deikstraSearch(graph, costs, parents);

            foreach (var obj in res)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();

        }
    }
}
