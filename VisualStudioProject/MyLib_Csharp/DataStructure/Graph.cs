using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    public partial class Graph<T>
    {
        public readonly LinkedList<LinkedNode<T>> nodes = new LinkedList<LinkedNode<T>>();

        public Graph(params LinkedNode<T>[] nodes)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                this.nodes.AddLast(nodes[i]);
            }
        }

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

        public Graph<T> ForEach(Action<LinkedNode<T>> forEach)
        {
            foreach (LinkedNode<T> node in nodes)
            {
                forEach(node);
            }
            return this;
        }

    }
}
