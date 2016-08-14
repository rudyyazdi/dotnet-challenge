using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[] words = Program.Read("data/names.txt");
      Array.Sort(words);
      Console.WriteLine(Program.TextValue("abC"));
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
    public static T[] Concat<T>(T[] x, T[] y)
    {
      int oldLen = x.Length;
      Array.Resize<T>(ref x, x.Length + y.Length);
      Array.Copy(y, 0, x, oldLen, y.Length);
      return x;
    }
  }
}
