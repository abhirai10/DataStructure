namespace DataStructure.Tree.BinarySearchTree
{
    public class Search
    {
        public static bool IsPresentRecursive(Node root, int value)
        {
            if (root == null) return false;

            if (root.data == value)
                return true;
            else if (root.data > value)
                return IsPresentRecursive(root.left, value);
            else
                return IsPresentRecursive(root.right, value);

        }


        public static bool IsPresentIterative(Node root, int value)
        {
            if (root == null)
                return false;

            while (root != null)
            {
                if (root.data == value)
                    return true;
                else if (root.data > value)
                    root = root.left;
                else
                    root = root.right;
            }

            return false;
        }

    }
    /* 
        Time complexity: O(h), where h is the height of the BST.
        Auxiliary Space in Recursive : O(h), where h is the height of the BST. 
        This is because the maximum amount of space needed to store the recursion stack would be h.
        
        Auxiliary Space in Recursive : O(1)
     */

}
