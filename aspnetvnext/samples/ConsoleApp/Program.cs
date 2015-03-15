using System;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        if (args != null && args.Length > 0)
        {
            foreach(var file in 
                Directory.GetFiles(args.First())
                .Select(f => new FileInfo(f))
                .OrderBy(fi => fi.Length))
            {
                Console.WriteLine("There is {0} with size {1}", file.Name, file.Length);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Hello From .NET Core World!");
    }
}
