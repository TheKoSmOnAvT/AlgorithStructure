using System;
using StructureAlgorithms.structur;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace StructureAlgorithms.Algorithms
{
    public class GraphSearch
    {
        public bool widthSearch<Tkey>(Dictionary<Tkey, IEnumerable<Tkey> > graph, Tkey startElement, Tkey searchedElement)
        {
            var queue = new structur.Queue<Tkey>();
            var searched = new List<Tkey>();
            queue.Push(startElement);
            while (!queue.isEmpty())
            {
                var key = queue.Pop();
                if (!searched.Contains(key) && graph.ContainsKey(key))
                {
                    searched.Add(key);
                    foreach (var element in graph[key])
                    {
                        if (element.Equals(searchedElement))
                        {
                            Console.WriteLine("searched");
                            return true;
                        }
                        else
                        {
                            queue.Push(element);
                        }
                    }
                }
            }
            Console.WriteLine("NotFound");
            return false;
        }

        public Dictionary<Tkey, double> deikstraSearch<Tkey>(Dictionary<Tkey, Dictionary<Tkey, double>> graph, Dictionary<Tkey, double> costs, Dictionary<Tkey, Tkey> parents)
        {
            var processed = new List<Tkey>();
            Tkey node = lowerCostNode(costs, processed);
            while (!node.Equals(null))
            {
                var cost = costs[node];
                var neighbors = graph[node];
                if (neighbors != null) {
                    foreach (var n in neighbors)
                    {
                        var newCost = cost + neighbors[n.Key];
                        if (costs[n.Key] > newCost)
                        {
                            costs[n.Key] = newCost;
                            parents[n.Key] = node;
                        }
                    }
                }
                processed.Add(node);
                node = lowerCostNode(costs, processed);
                if(node == null)
                {
                    return costs;
                }
            }
            return costs;
        }

        private Tkey lowerCostNode<Tkey>(Dictionary<Tkey, double> costs, IEnumerable<Tkey> processed)
        {
            var lowestCost = double.PositiveInfinity;
            Tkey minNode = default(Tkey);
            foreach(var costElement in costs)
            {
                var cost = costElement.Value;
                if (cost < lowestCost && !processed.Contains(costElement.Key))
                {
                    lowestCost = cost;
                    minNode = costElement.Key;
                }
            }
            return minNode;
        }
    }
}
