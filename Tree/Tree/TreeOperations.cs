using System.Collections.Generic;
using System;
namespace Tree
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        // Root of Binary Tree 
        public Node root;

        // Constructors 
        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null;
        }

        public void PreOrderRecurrsive(Node N)
        {
            if (N != null)
            {
                 PreOrderRecurrsive(N.left);
                  PreOrderRecurrsive(N.right);
                Console.WriteLine(N.key);
               
               
            }
        }
        public void PreOrderByLoop()
        {
            Stack<Node> st = new Stack<Node>();
            st.Push(root);
            Node temp = null;
            while (st.Count != 0)
            {

                temp = st.Pop();
                Console.WriteLine(temp.key);
                
                if (temp.right != null)
                    st.Push(temp.right);

                    if (temp.left != null)
                    st.Push(temp.left);

            }
        }
        
        

        public void InOrderbyLopp()
        {
            Stack<Node> st = new Stack<Node>();
            var temp = root;
            while (true)
            {
                while (temp != null)
                {
                    st.Push(temp);
                    temp = temp.left;
                }
                if (st.Count == 0)
                    break;
                temp = st.Pop();
                Console.WriteLine(temp.key);
                temp = temp.right;
            }            
        }

        public void LevelorderTraversal()
        {
            Queue<Node> q = new Queue<Node>();
            Node temp = null;
            q.Enqueue(root);
            while (q.Count != 0)
            {
                temp = q.Dequeue();
                Console.WriteLine(temp.key);
                if (temp.left != null)
                    q.Enqueue(temp.left);
                if (temp.right != null)
                    q.Enqueue(temp.right);
            }
        }
    }
}