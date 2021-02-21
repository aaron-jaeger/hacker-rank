using System;
using System.IO;
using System.Linq;

namespace AVeryBigSum
{
    class Program
    {
        // Complete the aVeryBigSum function below.
        static long AVeryBigSum(long[] ar)
        {
            var sum = ar.AsEnumerable()
                .Aggregate((number, next) => number + next);

            return sum;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = AVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
