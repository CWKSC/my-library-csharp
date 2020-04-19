using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    public class GraphNode<T> : LinkedNode<T, GraphNode<T>>
    {
        public bool visited = false;
        public GraphNode<T> from;

        public GraphNode(T data) : base(data) { }

        public GraphNode(params GraphNode<T>[] childs) : base(childs) { }


    }
}
