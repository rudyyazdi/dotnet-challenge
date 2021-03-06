using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[] words = Program.Read("data/names.txt");
      Array.Sort(words);
      Console.WriteLine(CalcAll(words));
    }
    private static int CalcAll(string[] words)
    {
      int i = 1; int total = 0;
      foreach(string word in words) total += Program.TextValue(word) * i; i++;
      return total;      
    }
    private static int TextValue(string word)
    {
      word = Regex.Replace(word.ToUpper(), @"[^A-Z]+", String.Empty);
      int res = 0;
      foreach(char c in word) res += c - 64;
      return res;
    }
    private static string[] Read(string path)
    {
      string data = System.IO.File.ReadAllText(path);
      return data.Split(',');
    }
  }
}
