using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    class Graph<T>
    {
        public readonly LinkedList<LinkedNode<T>> nodes = new LinkedList<LinkedNode<T>>();

        public Graph<T> AddNode(LinkedNode<T> node)
        {
            nodes.AddLast(node);
            return this;
        }

        public Graph<T> RemoveNode(LinkedNode<T> node)
        {
            nodes.Remove(node);
            return this;
        }

    }
}
