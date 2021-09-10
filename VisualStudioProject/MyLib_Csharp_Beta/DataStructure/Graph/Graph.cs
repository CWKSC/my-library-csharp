using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib_Csharp_Beta.DataStructure
{
    public partial class Graph<Node, Edge> where Node : IComparable<Node>
    {

        public Dictionary<Node, Dictionary<Node, Edge>> graph = new();

        public Dictionary<Node, Edge> this[Node key]
        {
            get => graph[key];
        }

        public void AddEdge(Node a, Node b, Edge edge)
        {
            if (graph.ContainsKey(a) == false)
            {
                graph.Add(a, new Dictionary<Node, Edge>());
                graph[a].Add(b, edge);
            }
            else
            {
                graph[a].Add(b, edge);
            }
        }

    }


}
