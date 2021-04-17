using Searching;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UDLinkedList;

namespace TestApplication
{
    class Program
    {
        public static List<int> allCounts { get; set; } = new List<int>();

        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //List<int> data = Enumerable.Range(1, 10).ToList<int>();
            //PrintRecursion(data, 0);
            //SolveProblem();
            //UDLinkedList();
            TestSearching();
            Console.ReadKey();
        }

        #region Searching Algo Test
        public static void TestSearching() {
            int[] data = Enumerable.Range(1, 100000000).ToArray<int>();

            int dataToFind = 100000000;
            var watch = new Stopwatch();
            watch.Start();
            var result = BinarySearch.Recursive(data, dataToFind, 0, data.Length - 1);
            Console.WriteLine(result);
            watch.Stop();
            Console.WriteLine($"Total Execution Time Binary Recursive: {watch.ElapsedMilliseconds} ms");


            if (!watch.IsRunning)
                watch.Restart(); // Reset time to 0 and start measuring


            watch.Start();
            result = BinarySearch.Iterative(data, dataToFind);
            Console.WriteLine(result);
            watch.Stop();
            Console.WriteLine($"Total Execution Time Binary Iterative: {watch.ElapsedMilliseconds} ms");

            if (!watch.IsRunning)
                watch.Restart(); // Reset time to 0 and start measuring


            watch.Start();
            result = LinearSearch.Normal(data, dataToFind);
            Console.WriteLine(result);
            watch.Stop();
            Console.WriteLine($"Total Execution Time Linear: {watch.ElapsedMilliseconds} ms");
        }
        #endregion

        #region Work On UDLinked List
        public static void UDLinkedList() {
           UDLinkedList.UDLinkedList uDLinkedList = new UDLinkedList.UDLinkedList();
            uDLinkedList.AddToLast(10);
            uDLinkedList.AddToLast("Saket");
            uDLinkedList.AddToLast("Vats");
            uDLinkedList.AddToLast("Duck");
            uDLinkedList.printAllNodes();
            Console.WriteLine("Middle Element :");
            uDLinkedList.FindMiddleNode();
        }
        #endregion

        #region Work on recursion Problem
        private static void SolveProblem()
        {
            int[] items =Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
            int[,] data = new int[items[0], items[1]];
            for (int i = 0; i < items[0]; i++) {
                    int[] temp = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                data[i, 0] = temp[0];
                data[i, 1] = temp[1];
            }

           int result = GetSolution(items,data, 0);
            Console.WriteLine("Result: " + result);
        }

        private static int  GetSolution(int[] items, int[,] data, int v)
        {
            int i = 0;
            int j = 0;
            RecursiveWay(i, j, items, data, v);
            if (allCounts.Count == 0)
                return -1;
            return allCounts.Min();
        }

        private static void RecursiveWay(int i, int j, int[] items, int[,] data, int v)
        {
            if (i >= items[0] || j >= items[1])
                return;
            if (CheckReachedDestination(i, j, items))
            {
                //Console.WriteLine()
                allCounts.Add(v);
            }
            int[,] possibleMoves = GetPossibleMoves(i, j, data[i,j]);
            v++;
            RecursiveWay(possibleMoves[0,0], possibleMoves[0,1], items, data, v);
            RecursiveWay(possibleMoves[1, 0], possibleMoves[1, 1], items, data, v);
        }

        private static bool CheckReachedDestination(int j1, int j2, int[] items)
        {
            if (j1+1 == items[0] && j2+1 == items[1])
                return true;
            return false;
        }

        private static int[,] GetPossibleMoves(int x, int y, int val)
        {
            return new int[2, 2] {{x + val, y}, { x, y + val } };
        }

        #endregion



        private static void PrintRecursion(List<int> data, int v)
        {

            if (v != data.Count-1)
                PrintRecursion(data, v + 1);
            Console.WriteLine(data[v]);
        }
    }
}
