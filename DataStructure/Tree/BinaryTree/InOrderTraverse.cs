namespace DataStructure.Tree.BinaryTree
{
    
    internal class InOrderTraverse
    {        
        public static void Traverse(Node root)
        {
            if (root == null)
                return;

            Traverse(root.left);
            Console.Write($"{root.data} ");
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
        Use cases of Inorder Traversal:
        
        In the case of BST (Binary Search Tree), if any time there is a need to get the nodes in non-decreasing order,
        the best way is to implement an inorder traversal.
    */

}
