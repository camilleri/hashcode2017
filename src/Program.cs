using System;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var header = Console.ReadLine().Split().ToList().Select(int.Parse).ToList();
            int nrows = header[0];

            for(int i=0; i<nrows;i++)
            {
                var line = Console.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
