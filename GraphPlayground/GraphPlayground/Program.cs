using System;
using System.Diagnostics;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = startNode;
            while (true)
            {
                Console.WriteLine($"Aktuálně jsem v uzlu {currentNode.index}");
                Node neighborsRemaining = null;
                foreach(Node neighbor in currentNode.neighbors)
                    if (!neighbor.visited)
                    {
                        neighborsRemaining = neighbor;
                        break;
                    }
                if (neighborsRemaining==null)
                {
                    if (neighborsRemaining==startNode)
                    {
                        Console.WriteLine($"Aktuálně jsem ve startovacím uzlu.");
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.cameFrom;
                    }
                }
                else
                {
                    currentNode.cameFrom = currentNode;
                    neighborsRemaining = null;
                    currentNode = neighborsRemaining;
                }
            }
            
            
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}
