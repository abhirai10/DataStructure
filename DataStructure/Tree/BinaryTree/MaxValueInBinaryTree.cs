namespace DataStructure.Tree.BinaryTree
{
    public class MaxValueInBinaryTree
    {
        public static int Get(Node root)
        {
            if(root == null)
                return int.MinValue;

            return Math.Max(root.data, Math.Max(Get(root.left), Get(root.right)));
        }
    }

    /* 
        Since this program is similar to preorder traversal of tree, time and space complexities will be same as Tree traversal
     */

}
