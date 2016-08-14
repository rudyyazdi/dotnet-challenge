using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[] words = Program.Read("data/names.txt");
      Array.Sort(words);
      Console.WriteLine(Program.TextValue("worddd"));
    }
    private static int TextValue(string word)
    {
      return 3;
    }
    private static string[] Read(string path)
    {
      string data = System.IO.File.ReadAllText(path);
      return data.Split(',');
    }
  }
}
