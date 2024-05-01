namespace DataStructure.Tree.BinaryTree
{
    public class IterativePreOrderTraverse
    {
        public static void Traverse(Node root)
        {
            if (root == null) return;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                Console.Write($"{current.data} ");

                // Push right node to stack first then left. So that when we Pop the left is popped first.
                if (current.right != null) 
                    stack.Push(current.right);

                if (current.left != null)
                    stack.Push(current.left); ;
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
