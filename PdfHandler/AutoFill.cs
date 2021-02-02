using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor
{
  public static class AutoFill
  {
    public static string ReplaceAll(string htmlString,Dictionary<string, string> dictToChange)
    {
      StringBuilder sb = new StringBuilder(htmlString);
      foreach(var text in dictToChange)
      {
        sb.Replace(text.Key, text.Value);
      }
      return sb.ToString();
    }
  }
}
