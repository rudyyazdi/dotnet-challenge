using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var data = System.IO.File.ReadAllText("data/names.txt");
      var words = data.Split(',');
      foreach (var word in words)
         Console.WriteLine(word);
    }
  }
}
