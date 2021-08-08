using System;
using AlgorithmsSoftuni.Recursion;
using AlgorithmsSoftuni.Recursion.Backtracking;
using AlgorithmsSoftuni.Recursion.Exercise;

namespace AlgorithmsSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDisks = 3;//int.Parse(Console.ReadLine());
            //source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            //TowersOfHanoi.Solve(numberOfDisks);
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 1);
            g.AddEdge(2, 3);
            g.AddEdge(3, 1);
            g.AddEdge(3, 2);

            g.PrintGraph();
        }
        //static void Main(string[] args)
        //{
        //    int n = 5;// Int32.Parse(Console.ReadLine());
        //    int k = 3;// Int32.Parse(Console.ReadLine());

        //    CombinationsWithRepetition.Recur(n, k);
        //}
        //static void Main(string[] args)
        //{

        //    Generating01Vectors generating01Vectors = new Generating01Vectors();
        //    int input = 3;// Convert.ToInt32(Console.ReadLine());
        //    int[] arr = new int[input];
        //    generating01Vectors.Generate(arr, 0);
        //    //Console.WriteLine("test");
        //}
        //static void Main(string[] args)
        //{
        //    GeneratingCombinations generatingCombinations = new GeneratingCombinations();
        //    //int k = Convert.ToInt32(Console.ReadLine());
        //    int k = 2;
        //    int[] arr = new int[] { 1, 2, 3 };
        //    generatingCombinations.Generate(arr, new int[k], 0, 0);
        //    //Console.WriteLine(rec);
        //}
        //static void Main(string[] args)
        //{
        //    //QueensProblemSolution queensProblemSolution = new QueensProblemSolution();
        //    //QueensProblemSolution.PutQueens(0);
        //    //QueensProblem2.QueenProblem(0,8);

        //    // PawnsProblem.PawnProblem(0, 8);



        //    //LabyrinthPaths.FindPath(0, 0);
        //    //ReversedArray.
        //   // int[] arr = { 1,2,3,4,5};
        //    string foo = Console.ReadLine();
        //    string[] tokens = foo.Split(" ");
        //    int[] nums = new int[tokens.Length];

        //    for (int i = 0; i < tokens.Length; i++)
        //    {
        //        nums[i] = Int32.Parse(tokens[i]);
        //    }
        //    ReverseArray.Reverse(nums);
        //    //ReverseArray.Reverse(arr);
        //}
        //static void Main(string[] args)
        //{
        //    QueensProblem generatingCombinations = new QueensProblem();
        //    //int k = Convert.ToInt32(Console.ReadLine());

        //    const int Size = 4;
        //    bool[,] chessboard = new bool[Size, Size];
        //    bool[,] queensOnChessboard = new bool[Size, Size];

        //    generatingCombinations.EightQueensProblem(chessboard, queensOnChessboard, 0, 0);
        //    //Console.WriteLine(rec);
        //}
        private static int Sum(int[] arr, int index)
        {
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            if (arr.Length == index)
            {
                return 0;
            }
            //index++;

            return Sum(arr, index++) + arr[index];

        }


    }
}

//https://softuni.bg/trainings/1907/algorithms-march-2018#lesson-8054
//https://judge.softuni.bg/Contests/Practice/Index/688#3
// https://softuni.bg/trainings/resources/officedocument/29869/exercise-problem-descriptions-recursion-algorithms-march-2018/1907
//https://www.youtube.com/watch?v=vS-LA-LEzX0&feature=youtu.be&t=4