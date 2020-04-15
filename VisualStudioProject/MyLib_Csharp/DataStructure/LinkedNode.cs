using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    class LinkedNode<T>
    {
        public T data;
        public LinkedList<LinkedNode<T>> children = new LinkedList<LinkedNode<T>>();

        public LinkedNode(T data) => this.data = data;

        public void AddChild(LinkedNode<T> child) => children.AddLast(child);

        public void RemoveChild(LinkedNode<T> child) => children.Remove(child);

    }


}
