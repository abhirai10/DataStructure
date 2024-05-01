namespace DataStructure.Tree.BinaryTree
{
    public class IterativeInOrderTraverse
    {
        public static void Traverse(Node root)
        {
            if (root == null) return;
            
            Stack<Node> stack = new Stack<Node>();
            Node current = root;
            while(current != null || stack.Count > 0)
            {
                while(current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                Console.Write($"{current.data} ");
                current = current.right;
            }
        }

    }

    /*
       Complexity Analysis:

       Time Complexity: O(N) where N is the total number of nodes. Because it traverses all the nodes at least once to push to stack.

       Auxiliary Space: 

       O(1) if only 1 node is pushed to stack. 
       Otherwise, O(h) where h is the height of the tree
       In the worst case, h can be the same as N (when the tree is a skewed tree)
       In the best case, h can be the same as logN (when the tree is a complete tree)
   */

}
