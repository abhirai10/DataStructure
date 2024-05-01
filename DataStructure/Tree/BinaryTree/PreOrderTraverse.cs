namespace DataStructure.Tree.BinaryTree
{
    public class PreOrderTraverse
    {       
        public static void Traverse(Node root)
        {
            if (root == null)
                return;

            Console.Write($"{root.data} ");
            Traverse(root.left);
            Traverse(root.right);

        }
    }

    /*
        Complexity Analysis:
        
        Time Complexity: O(N) where N is the total number of nodes. Because it traverses all the nodes at least once.
        
        Auxiliary Space: 

        O(1) if no recursion stack space is considered. 
        Otherwise, O(h) where h is the height of the tree
        In the worst case, h can be the same as N (when the tree is a skewed tree)
        In the best case, h can be the same as logN (when the tree is a complete tree)
    */

    //------------------------------------------------------------------------------------------------------------------

    /* 
        Some use cases of preorder traversal are:

        This is often used for creating a copy of a tree.
        It is also useful to get the prefix expression from an expression tree.
     */

}
