namespace DataStructure.Tree.BinaryTree
{
    public class IterativePreOrderSpaceOptimizedTraverse
	{
		public static void Traverse(Node root)
		{
			if (root == null) return;

			Stack<Node> stack = new Stack<Node>();
			Node current = root;			
			while (current != null || stack.Count > 0)
			{
				// Iterate over left child, print it and push only right to stack if it exists
				while (current != null)
				{
					Console.Write($"{current.data} ");

					if( current.right != null) 
						stack.Push(current.right);

					current = current.left;
				}
				
				// Pop right node and follow the same cycle
				if(stack.Count > 0)
					current = stack.Pop();
			}
		}

	}

	/*
	   
	   The idea is to start traversing the tree from the root node, and keep printing the left child while exists and simultaneously, push the right child of every node in an auxiliary stack. Once we reach a null node, pop a right child from the auxiliary stack and repeat the process while the auxiliary stack is not-empty. 
	   This is a micro-optimization over the previous approach, both the solutions use asymptotically similar auxiliary space.
	  
       Complexity Analysis:

       Time Complexity: O(N) where N is the total number of nodes. Because it traverses all the nodes at least once to push to stack.

       Auxiliary Space: 

       O(1) if only 1 node is pushed to stack. 
       Otherwise, O(h) where h is the height of the tree
       In the worst case, h can be the same as N (when the tree is a skewed tree)
       In the best case, h can be the same as logN (when the tree is a complete tree)
   */

}
