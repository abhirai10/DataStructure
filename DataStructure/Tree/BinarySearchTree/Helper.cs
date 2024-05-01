namespace DataStructure.Tree.BinarySearchTree
{
    public class Helper
    {
        public static void ExecutePrograms()
        {
            var node = CreateBinarySearchTree();

            Console.WriteLine($"Binary search tree search Recursive No 30 found : {Search.IsPresentRecursive(node, 30)}"  );

            Console.WriteLine($"Binary search tree search Iterative No 50 found : {Search.IsPresentIterative(node, 50)}" );




        }

        private static Node CreateBinarySearchTree()
        {
            Node root = new Node(20);
            root.left = new Node(10);
            root.left.left = new Node(5);
            root.right = new Node(40);
            root.right.left = new Node(30);
            root.right.right = new Node(50);

            return root;
        }
    }
}
