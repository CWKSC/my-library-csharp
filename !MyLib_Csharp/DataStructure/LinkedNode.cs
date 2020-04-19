using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    public class LinkedNode
    {
        public LinkedList<LinkedNode> childrens = new LinkedList<LinkedNode>();
        public LinkedNode(params LinkedNode[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void AddChild(LinkedNode child) => childrens.AddLast(child);

        public void RemoveChild(LinkedNode child) => childrens.Remove(child);

        public LinkedNode ForEach(Action<LinkedNode> forEach)
        {
            foreach (LinkedNode child in childrens)
            {
                forEach(child);
            }
            return this;
        }
    }


    public class LinkedNode<T>
    {
        public T data;
        public LinkedList<LinkedNode<T>> childrens = new LinkedList<LinkedNode<T>>();

        public LinkedNode(T data) => this.data = data;
        public LinkedNode(params LinkedNode<T>[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void AddChild(LinkedNode<T> child) => childrens.AddLast(child);

        public void RemoveChild(LinkedNode<T> child) => childrens.Remove(child);


        public LinkedNode<T> ForEach(Action<LinkedNode<T>> forEach)
        {
            foreach (LinkedNode<T> child in childrens)
            {
                forEach(child);
            }
            return this;
        }

    }

    public class LinkedNode<T, Class> where Class : LinkedNode<T, Class>
    {

        public T data;
        public LinkedList<Class> childrens = new LinkedList<Class>();

        public LinkedNode(T data) => this.data = data;

        public LinkedNode(params Class[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void AddChild(Class child) => childrens.AddLast(child);
        public void AddChilds(params Class[] childs)
        {
            for (int i = 0; i < childs.Length; i++)
            {
                childrens.AddLast(childs[i]);
            }
        }

        public void RemoveChild(Class child) => childrens.Remove(child);

        public LinkedNode<T, Class> ForEach(Action<Class> forEach)
        {
            foreach (Class child in childrens)
            {
                forEach(child);
            }
            return this;
        }

    }



}
