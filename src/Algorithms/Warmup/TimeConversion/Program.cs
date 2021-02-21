using System;
using System.IO;

namespace TimeConversion
{
    class Program
    {
        /*
         * Complete the timeConversion function below.
         */
        static string TimeConversion(string s)
        {
            var time = DateTime.Parse(s);

            var result = time.ToString("HH:mm:ss");

            return result;
        }

        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = TimeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }
    }
}
