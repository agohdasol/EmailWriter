using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileHandler
{
  public class HtmlParser
  {
    public static string HtmlToString(string fileName)
    {
      string lines;
      if (File.Exists(fileName))
      {
        try
        {
          lines = File.ReadAllText(fileName, Encoding.Default);
        }
        catch (Exception)
        {
          lines = "";
        }
      }
      else
      {
        lines = "";
      }
      return lines;
    }
  }
}
