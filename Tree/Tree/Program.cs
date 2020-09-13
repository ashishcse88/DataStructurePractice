using System;

namespace Tree
{
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            /*create root*/
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.right.left = new Node(5);
            tree.root.left.left = new Node(4);
            tree.root.left.left.left = new Node(6);

            tree.PreOrderRecurrsive(tree.root);
            //Console.WriteLine("--------------------------");
            //tree.PreOrderByLoop();
            tree.InOrderbyLopp();
        }
    }

}
