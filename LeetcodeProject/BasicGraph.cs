using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class BasicGraph
    {
        private int totalVertices;
        private LinkedList<int>[] linkedListArray;

        public BasicGraph(int n)
        {
            totalVertices = n;
            linkedListArray = new LinkedList<int>[n];

            for (int i = 0; i < n; i++) {
                linkedListArray[i] = new LinkedList<int>();
            }
        }

        public void addEdge(int vertex, int adcvertex)
        {
            linkedListArray[vertex].AddLast(adcvertex);
        }

        public void PrintAdjaceyList()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("Graph Representation");
            Console.WriteLine("====================================================");
            Console.WriteLine("The Graph Adjancey List Representaiton");
            Console.WriteLine("====================================================");

            StringBuilder nodeString = new StringBuilder();
            for (int i = 0; i < linkedListArray.Length; i++)
            {
                nodeString.Append("[Node Value: " + i + " with Neighbors");
                foreach (var item in linkedListArray[i])
                {
                    nodeString.Append(" -> " + item);
                }
                nodeString.Append(" ]\n");
            }

            Console.WriteLine(nodeString.ToString());

        }

    }
}
