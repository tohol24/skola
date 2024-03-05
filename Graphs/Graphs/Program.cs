using System;
using System.Collections.Generic;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-4,6
             * 2-3,5,6
             * 3-2,5
             * 4-1,6
             * 5-1,2
             * 6-1,2,4
             */
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            
            node1.AddNeighbor(node4);
            node1.AddNeighbor(node6);
            
            node2.AddNeighbor(node3);
            node2.AddNeighbor(node5);
            node2.AddNeighbor(node6);
            
            node3.AddNeighbor(node2);
            node3.AddNeighbor(node5);
            
            node4.AddNeighbor(node1);
            node4.AddNeighbor(node6);
            
            node5.AddNeighbor(node1);
            node5.AddNeighbor(node2);
            
            node6.AddNeighbor(node1);
            node6.AddNeighbor(node2);
            node6.AddNeighbor(node4);

            Node currentNode = node1;
            while(true)
            {
            }
            Console.ReadKey();
        }
        class Node
        {

            private int index;
            private List<Node> neighbors;
            public Node(int index)
            {
                this.index = index;
                neighbors = new List<Node>();
            }
            public void AddNeighbor(Node node)
            {
                if (neighbors.Contains(node))
                {
                    Console.WriteLine("Hele..., Ne!");
                }
                else
                {
                    neighbors.Add(node);
                    node.AddNeighbor(this);
                    Console.WriteLine($"Čoveče..., byl přidán index {node}");
                }
            }
            public void ShowLists()
            {
                Console.WriteLine(neighbors);
                Console.ReadKey();
            }
        }
    }
}
