using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;
using MyLib_Csharp_Beta.Algorithm.GraphTraversal;
using MyLib_Csharp_Beta.CommonMethod;

namespace MyLib_Csharp_Beta.DataStructure
{
    public partial class Graph
    {

        public static void Test()
        {
            Graph<string, int> graph = new();

            ApplyFunction.ApplyFunc(
                args => graph.AddEdge(args.Item1, args.Item2, 1),
                ("0", "4"),
                ("0", "7"),
                ("1", "0"),
                ("1", "2"),
                ("1", "3"),
                ("3", "1"),
                ("3", "2"),
                ("3", "7"),
                ("4", "6"),
                ("4", "7"),
                ("5", "4"),
                ("6", "5"),
                ("7", "5"));


            Dictionary<string, string> parents = new();
            bool finded;
            finded = graph.ShortestPath_BFS("0", "1", parents);

            (finded ? "Finded" : "Not Find").Println();

            foreach(var pair in parents)
            {
                (pair.Value + " -> " + pair.Key).Println();
            }

            //graph["0"]["4"] = 1;
            //graph["0"]["7"] = 1;

        }

    }
}
