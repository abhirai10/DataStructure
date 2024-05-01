namespace DataStructure.Tree.BinarySearchTree
{
    public class Insert
    {
        public static Node DataRecursive(Node root,int value)
        {
            if(root == null)
                return new Node(value);
            else if(root.data > value)
                root.left = DataRecursive(root.left, value);
            else if (root.data < value)
                root.right = DataRecursive(root.right, value);
            
            return root;
        }

        public static Node DataIterative(Node root, int value)
        {
            Node temp = new Node(value);
            Node parent = null;
            Node current = root;

            while (current != null)
            {
                parent = current;
                if (current.data > value)
                    current = current.left;
                else if (current.data < value)
                    current = current.right;
                else
                    return root;
            }

            if (parent == null)
                return temp;
            
            if(parent.data > value)
                parent.left = temp;
            else 
                parent.right = temp;

            return root;

        }
    }
}
