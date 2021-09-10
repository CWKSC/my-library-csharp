using MyLib_Csharp_Beta.DataStructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace MyLib_Csharp_Beta.Algorithm.GraphTraversal
{
    public static class BFSMethod
    {

        public class GenericIComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public int Compare(T x, T y)
            {
                return x.CompareTo(y);
            }
        }

        public class State<Node>
        {
            Node node;
            Node parent;
        }

        public static bool ShortestPath_BFS<Node, Edge>(this Graph<Node, Edge> graph, 
            Node start, Node end, in Dictionary<Node, Node> parents) where Node : IComparable<Node>, IComparable
            where Edge : IComparable<Edge>, IComparable
        {
            SortedList<Edge, Node> queue = new(new GenericIComparer<Edge>());
            HashSet<Node> visited = new();
            queue.Add(default, start);
            while (queue.Count != 0)
            {
                var ele = queue.Min();
                Node node = ele.Key;
                Node parent = ele.Value;
                queue.Remove(node);

                if (node.Equals(end)) return true;

                if (visited.Contains(node)) continue;
                visited.Add(node);
                parents[node] = parent;

                Dictionary<Node, Edge> toEdges = graph[node];
                foreach (var toEdge in toEdges)
                {
                    Node other = toEdge.Key;
                    if (visited.Contains(other)) continue;
                    queue.Add(other, node);
                }
            }
            return false;
        }


    }
}
