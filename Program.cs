using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string[] words = Program.Read("data/names.txt");
      Array.Sort(words);
      char[] test = "woorrd".ToCharArray();
      Console.WriteLine(Program.TextValue("worddd"));
      int[] con1 = {1};
      int[] con2 = {1};
      int[] con3 = Program.Concat(con1, con2);
      foreach(int w in con3) Console.WriteLine(w);
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
    public static T[] Concat<T>(T[] x, T[] y)
    {
      int oldLen = x.Length;
      Array.Resize<T>(ref x, x.Length + y.Length);
      Array.Copy(y, 0, x, oldLen, y.Length);
      return x;
    }
  }
}
