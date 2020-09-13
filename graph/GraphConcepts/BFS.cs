using System;
using System.Collections.Generic;
public class BFS
{
    int V = 5;
    private LinkedList<int>[] adj;
    public BFS()
    {
        adj = new LinkedList<int>[V];
        for (int i = 0; i < adj.Length; i++)
        {
            adj[i] = new LinkedList<int>();
        }
    }
    void addEdge(int v, int u)
    {
        adj[v].AddLast(u);
        adj[u].AddLast(v);
    }
    private void PrintGraph()
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
    public void printBFS()
    {
        addEdge(0, 2);
        addEdge(0, 3);
        addEdge(1, 2);
        addEdge(1, 3);
        addEdge(1, 4);
        addEdge(2, 3);
        addEdge(3, 4);
        addEdge(2, 3);
        //PrintGraph();

        LinkedList<int> traverse = new LinkedList<int>();
        bool[] visitedNodes = new bool[V];
        traverse.AddLast(0);
        LinkedList<int> ll = new LinkedList<int>();
        int tempVal = 0;
        while (traverse.Count > 0)
        {
            tempVal = traverse.First.Value;
            traverse.RemoveFirst();

            if (!visitedNodes[tempVal])
            {
                visitedNodes[tempVal] = true;
                Console.WriteLine("Vertex visited " + tempVal.ToString());
                ll = adj[tempVal];
                foreach (int i in ll)
                {
                    if (!visitedNodes[i])
                        traverse.AddLast(i);
                        //this test for scene switch
                }
            }
        }

    }
}