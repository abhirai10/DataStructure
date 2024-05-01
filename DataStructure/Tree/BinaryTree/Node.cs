using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace DataStructure.Tree.BinaryTree
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
        }

        public static Node CreateBinaryTree()
        {
            Node root = new Node(10);
            root.left = new Node(20);
            root.right = new Node(30);
            root.left.left = new Node(40);

            return root;
        }
        
    }   

}
