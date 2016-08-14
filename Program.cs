using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[] words = Program.Read("data/names.txt");
      Array.Sort(words);
      int i = 1;
      int total = 0;
      foreach(string word in words) total += Program.TextValue(word) * i; i++;
      Console.WriteLine(total);
    }
    private static int TextValue(string word)
    {
      int res = 0;
      foreach(char c in word) res += char.ToUpper(c) - 64;
      return res;
    }
    private static string[] Read(string path)
    {
      string data = System.IO.File.ReadAllText(path);
      return data.Split(',');
    }
  }
}
