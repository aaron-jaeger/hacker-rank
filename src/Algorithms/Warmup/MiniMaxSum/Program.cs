using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void MiniMaxSum(int[] arr)
        {
            var sums = new List<long>();

            for (int i = 0; i < arr.Length; i++)
            {
                var shortenedList = arr.ToList();

                shortenedList.RemoveAt(i);

                var sum = shortenedList.AsEnumerable()
                    .Select(x => (long)x)
                    .Aggregate((number, next) => number + next);

                sums.Add(sum);
            }

            Console.WriteLine($"{sums.Min()} {sums.Max()}");
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            MiniMaxSum(arr);
        }
    }
}
