using System;
using System.Collections.Generic;

class YellowGraph : Graph {
   
   // List of nodes in this graph
   private List<Node> nodes;

   // An adjacency matrix, recording edges between nodes
   // Edge FROM node i to node j is recorded in adjMatrix[i,j]
   // Each int entry records the edge cost (> -1)
   // If entry is 0 there is no edge 
   private int[,] adjMatrix;

   public YellowGraph() {
      nodes = new List<Node>();
      adjMatrix = new int[0,0];
   }
     

    public void makeMatrix()
    {

        nodes n0 = new Node(0, 0);
        nodes n1 = new Node(1, 1);//create numbers in the nodes list
        nodes n2 = new Node(2, 2);

        adjMatrix.AddNode(n0);
        adjMatrix.AddNode(n1);//
        adjMatrix.AddNode(n2);

        adjMatrix.AddEdge(n0, n1);
        adjMatrix.AddEdge(n1, n0);
    }



   public void Write() {
      Console.WriteLine("YellowGraph");

      for (int i = 0; i < nodes.Count; i++) {
         Console.Write(nodes[i] + ": ");

         bool first = true;
         for (int j = 0; j < nodes.Count; j++) {
            if (adjMatrix[i,j] > 0) {
               if (!first) Console.Write(", ");
               Console.Write(nodes[j] + "(" + adjMatrix[i,j] + ")");
               first = false;
            }
         }

         Console.Write("\n");
      }
   }
}

