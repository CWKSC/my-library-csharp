using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Linq;

namespace MyLib_Csharp_Beta.DataStructure
{
    public partial class BinaryTree
    {
        
        public static void Test()
        {
            BinaryTreeNode<int> root =
                new(42,
                    new(1,
                        new(3),
                        new(4)
                        ),
                    new(2,
                        new(5),
                        new(6)
                        )
                    );
            root.PrintFields();
            "".Println();

            "Preorder".Println();
            root.Preorder(ele => (ele.value + " ").Print());
            "".Printlnln();

            "Inorder".Println();
            root.Inorder(ele => (ele.value + " ").Print());
            "".Printlnln();

            "Postorder".Println();
            root.Postorder(ele => (ele.value + " ").Print());
            "".Printlnln();

            "Height".Println();
            root.Height().Printlnln();


        }
    }


}
