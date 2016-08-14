using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
        {
            string data = System.IO.File.ReadAllText("data/names.txt");
            string[] words = data.Split(',');
            Array.Sort(words);
            foreach (var word in words) Console.WriteLine(word);
        }
    }
}
