using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsSoftuni.Recursion.Exercise
{
    public class TowersOfHanoi
    {

        static IEnumerable<int> range = Enumerable.Range(1, 3);

        static Stack<int> sourceRod = new Stack<int>(range);
        static Stack<int> destinationRod = new Stack<int>();
        static Stack<int> spareRod = new Stack<int>();

        private static int stepsTaken = 0;

        public static void Solve(int numDisks)
        {
            PrintRods();
            MoveDisks(numDisks, sourceRod, destinationRod, spareRod);
        }

        public static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {

            if (bottomDisk == 1)
            {
                stepsTaken++;

                destination.Push(source.Pop());

                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintRods();
            }
            else
            {
                // 1) move all disks from bottomDisk - 1 from source to spare;
                MoveDisks(bottomDisk - 1, source, spare, destination);
                stepsTaken++;
                destination.Push(source.Pop());  // 2) move the bottomDisk from source to destination;
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintRods();
                // 3) move all disks previously moved to spare to destination.
                MoveDisks(bottomDisk - 1, spare, destination, source);
            }
        }

        private static void PrintRods()
        {
            Console.WriteLine($"Source: {String.Join(", ", sourceRod.Reverse())}");
            Console.WriteLine($"Destination: {String.Join(", ", destinationRod.Reverse())}");
            Console.WriteLine($"Spare: {String.Join(", ", spareRod.Reverse())}");
            Console.WriteLine();
        }
    }
}
