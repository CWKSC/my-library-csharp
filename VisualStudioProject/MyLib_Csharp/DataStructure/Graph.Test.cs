using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    public partial class Graph<T>
    {

        public static void Test()
        {

            LinkedNode<int> A = new LinkedNode<int>(12);
            LinkedNode<int> B = new LinkedNode<int>(14);
            LinkedNode<int> C = new LinkedNode<int>(17);

            Graph<int> graph = new Graph<int>(A, B, C);
            graph.ForEach(node => Console.WriteLine(node.data));
        }

    }
}
