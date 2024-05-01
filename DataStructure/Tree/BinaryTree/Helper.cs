namespace DataStructure.Tree.BinaryTree
{
    public class Helper
    {

        public static void ExecutePrograms()
        {
            var node = Node.CreateBinaryTree();
            Console.WriteLine($"\nInOrder Traversal");
            InOrderTraverse.Traverse(node);

            Console.WriteLine("\nIterative InOrder Traversal");
            IterativeInOrderTraverse.Traverse(node);

            Console.WriteLine("\nPreOrder Traversal");
            PreOrderTraverse.Traverse(node);

            Console.WriteLine("\nIterative PreOrder Traversal");
            IterativePreOrderTraverse.Traverse(node);

            Console.WriteLine("\nIterative PreOrder Space Optimized Traversal");
            IterativePreOrderSpaceOptimizedTraverse.Traverse(node);

            Console.WriteLine("\nPostOrder Traversal");
            PostOrderTraverse.Traverse(node);

            Console.WriteLine($"\nSizeOfBinaryTree - {SizeOfBinaryTree.Get(node)}");

            Console.WriteLine($"Max Value in Binary Tree - {MaxValueInBinaryTree.Get(node)}");

            Console.WriteLine($"Max Value in Binary Tree - {HeightOfBinaryTree.Get(node)}");
        }

    }
}
