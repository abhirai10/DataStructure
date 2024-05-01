namespace DataStructure.Tree.BinaryTree
{
    public class SizeOfBinaryTree
    {
        public static int Get(Node root)
        {
            if (root == null)
                return 0;

            return 1 + Get(root.left) + Get(root.right);
        }
    }

    /* 
        Since this program is similar to traversal of tree, time and space complexities will be same as Tree traversal
     */
}
