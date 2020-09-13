using System;
using System.Collections.Generic;
namespace GraphConcepts
{

    class Program
    {
        static void addEdge(LinkedList<int>[] adj, int v, int u)
        {
            adj[v].AddLast(u);
            adj[u].AddLast(v);
        }
        static void PrintGraph(LinkedList<int>[] adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("Adjacency list of vertex " + i.ToString());
                Console.Write("Head");
                foreach (int val in adj[i])
                {
                    Console.Write(" --> " + val.ToString());
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Hello World!");
            int V = 5;
            LinkedList<int>[] adj = new LinkedList<int>[V];
            for (int i = 0; i < 5; i++)
            {
                adj[i] = new LinkedList<int>();
            }

            addEdge(adj, 0, 2);
            addEdge(adj, 0, 3);
            addEdge(adj, 1, 2);
            addEdge(adj, 1, 3);
            addEdge(adj, 1, 4);
            addEdge(adj, 2, 3);
            addEdge(adj, 3, 4);
            addEdge(adj, 2, 3);

            PrintGraph(adj);
            */

            BFS objBFS = new BFS();
            objBFS.printBFS();

        }
    }
}
