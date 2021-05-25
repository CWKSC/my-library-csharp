using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.DataStructure
{
    public class BinaryTreeNode<T>
    {
        public T value;
        public BinaryTreeNode<T> left = null, right = null;
        public BinaryTreeNode(T value)
        {
            this.value = value;
        }
        public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }

    public partial class BinaryTree<T>
    {
        public BinaryTreeNode<T> root;
    }

    public static class BinaryNode_Extension
    {
        public static void Preorder<T>(this BinaryTreeNode<T> root, Action<BinaryTreeNode<T>> action)
        {
            action(root);
            if (root.left != null) { Preorder(root.left, action); }
            if (root.right != null) { Preorder(root.right, action); }
        }
        public static void Inorder<T>(this BinaryTreeNode<T> root, Action<BinaryTreeNode<T>> action)
        {
            if (root.left != null) { Preorder(root.left, action); }
            action(root);
            if (root.right != null) { Preorder(root.right, action); }
        }
        public static void Postorder<T>(this BinaryTreeNode<T> root, Action<BinaryTreeNode<T>> action)
        {
            if (root.left != null) { Preorder(root.left, action); }
            if (root.right != null) { Preorder(root.right, action); }
            action(root);
        }

        public static int Height<T>(this BinaryTreeNode<T> root)
        {
            if (root == null) return -1;
            return Math.Max(Height(root.left), Height(root.right)) + 1;
        }
        public static int BalanceFactor<T>(this BinaryTreeNode<T> root)
        {
            return Height(root.left) - Height(root.right);
        }
        public static bool IsBalance<T>(this BinaryTreeNode<T> root)
        {
            int balanceFactor = root.BalanceFactor();
            return -1 <= balanceFactor && balanceFactor <= 1;
        }
        public static BinaryTreeNode<T> LeftRotation<T>(this BinaryTreeNode<T> root)
        {
            return null;
        }

    }
}
