using System;
namespace AlgorithmsSoftuni.Search.Pathfinding.Graph
{
    public class StringGraph
    {
        static int x0, y0;
        static int W, H;

        //static void Main(string[] args)
        //{
        //    // Read global inputs
        //    string[] inputs;
        //    inputs = Console.ReadLine().Split(' ');
        //    W = int.Parse(inputs[0]);
        //    H = int.Parse(inputs[1]);

        //    inputs = Console.ReadLine().Split(' ');
        //    y0 = int.Parse(inputs[0]);
        //    x0 = int.Parse(inputs[1]);

        //    // Read maps and keep track of the best one
        //    int numMaps = int.Parse(Console.ReadLine());
        //    int bestId = -1, bestLength = int.MaxValue;

        //    for (int i = 0; i < numMaps; i++)
        //    {
        //        // First store the map in a matrix (technically string array)
        //        var map = new string[H];
        //        for (int j = 0; j < H; j++)
        //            map[j] = Console.ReadLine();

        //        // Figure out how long the path is (or -1 if not valid)
        //        int length = explore(map);

        //        // Remember which map is best
        //        if (length == -1) continue;
        //        else if (length < bestLength)
        //        {
        //            bestLength = length;
        //            bestId = i;
        //        }
        //    }

        //    Console.WriteLine(bestId == -1 ? "TRAP" : bestId + "");
        //}
        //static int explore(string[] map)
        //{
        //    int steps = 0;
        //    int curX = x0, curY = y0;

        //    // Loop infinitely through the map depending on cell data
        //    // Three checks for invalid maps - return -1 if invalid:
        //    //   (1) Out of bounds
        //    //   (2) Looping map
        //    //   (3) Unexpected end

        //    for (; ; steps++)
        //    {
        //        if (curX == x0 && curY == y0 && steps > 0) return -1;
        //        if (curX >= W || curX < 0 || curY >= H || curY < 0) return -1;

        //        switch (map[curY][curX])
        //        {
        //            case '^': curY--; break;
        //            case 'v': curY++; break;
        //            case '<': curX--; break;
        //            case '>': curX++; break;
        //            case 'T': return steps + 1;
        //            default: return -1;
        //        }
        //    }
        //}
    }
}
