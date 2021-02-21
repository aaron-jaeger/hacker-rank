using System;
using System.Linq;


namespace SimpleArraySum
{
    class Program
    {
        /*
        * Complete the simpleArraySum function below.
        */
        static int SimpleArraySum(int[] ar)
        {
            var sum = ar.AsEnumerable()
                .Aggregate((number, next) => number + next);

            return sum;
        }

        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = SimpleArraySum(ar);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
