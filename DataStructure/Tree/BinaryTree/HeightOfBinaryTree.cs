namespace DataStructure.Tree.BinaryTree
{
    public class HeightOfBinaryTree
    {
        public static int Get(Node root)
        {
            if (root == null)
                return 0;

            return Math.Max(Get(root.left), Get(root.right)) + 1;
        }
    }

    /* 
        Since this program is similar to traversal of tree, time and space complexities will be same as Tree traversal
     */
}
