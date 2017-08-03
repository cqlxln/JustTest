using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Utility.Match(p);
            Console.WriteLine("Done.");
            Console.ReadKey();
        }

        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete + "%");
        }
        static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.AppendAllText("progress.txt", percentComplete + "%");
        }
    }

    public delegate void ProgressReporter(int percentComplete);

    public class Utility
    {
        public static void Match(ProgressReporter p)
        {
            if (p != null)
            {
                for (int i = 0; i <= 10; i++)
                {
                    p(i * 10);
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
    }
}
