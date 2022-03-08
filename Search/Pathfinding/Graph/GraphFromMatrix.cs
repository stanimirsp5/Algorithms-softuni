using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithmsSoftuni.Search.Pathfinding.Graph
{
    public class GraphFromMatrix
    {
        private LinkedList<Dictionary<int, string>>[] adjList;

        public GraphFromMatrix()
        {
            string[,] map = { { ".",">",">","v" },
                              { ".","^","#","v" },
                              { ".",".","#","v" },
                              { ".",".",".","T" }
                            };
            //int[,] map = {  { 0,1,2 },
            //                { 3,4,5 },
            //                { 6,7,8},
            //             };

            BuildGraph(map);



        }

        public void BuildGraph(string[,] arr2d)
        {

            Graph(arr2d.Length);


            for (int row = 0; row < arr2d.GetLength(0); row++)
            {
                for (int col = 0; col < arr2d.GetLength(1); col++)
                {
                    if (row - 1 >= 0) // up
                    {
                        var mapSymbol = arr2d[row - 1, col];
                        //var currentVertex = ;
                        //var toVertex = ;
                        //Edge(currentVertex, toVertex, mapSymbol);
                    }
                    if (row + 1 < arr2d.GetLength(0)) // down
                    {
                        var vertexToAdd = arr2d[row + 1, col];
                        //Edge(arr2d[row, col], vertexToAdd);
                    }
                    if (col - 1 >= 0) // left
                    {
                        var vertexToAdd = arr2d[row, col - 1];
                        //Edge(arr2d[row, col], vertexToAdd);
                    }
                    if (col + 1 < arr2d.GetLength(1)) // right
                    {
                        var vertexToAdd = arr2d[row, col + 1];
                        //Edge(arr2d[row, col], vertexToAdd);
                    }
                }
            }

            PrintGraph();
        }

        public void Graph(int vertices)
        {

            adjList = new LinkedList<Dictionary<int, string>>[vertices];
            var test = adjList.FirstOrDefault();
            var tppl = test.FirstOrDefault();
            tppl.Add(1,"*");
            for (int i = 0; i < vertices; i++)
            {
                adjList[i] = new LinkedList<Dictionary<int, string>>();
            }

        }

        public void Edge(int vertex, int vertexToAdd, string charV)
        {
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(vertexToAdd, charV);
            adjList[vertex].AddLast(dictionary);
        }

        public void PrintGraph()
        {
            for (int v = 0; v < adjList.Count(); v++)
            {
                Console.Write("V :" + v);
                for (int e = 0; e < adjList[v].Count(); e++)
                {
                    Console.Write(" -> " + adjList[v].ElementAt(e));
                }
                Console.WriteLine();
            }

        }

    }
}
