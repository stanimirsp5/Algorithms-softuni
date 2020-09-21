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

        public static void Solve()
        {
            MoveDisks(3, sourceRod, destinationRod, spareRod);
        }

        public static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {

            if (source.Peek() == 1)
            {
               destination.Push(source.Pop());
            }
            else
            {
                // 1) move all disks from bottomDisk - 1 from source to spare;
                destination.Push(source.Pop()); // 2) move the bottomDisk from source to destination;
                // 3) move all disks from bottomDisk – 1 from spare to destination.
            }



        }
    }
}
