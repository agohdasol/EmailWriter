using System;
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
          Stream htmlStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
          StreamReader docStreamReader = new StreamReader(htmlStream, System.Text.Encoding.Default);
          htmlStream.Position = 0;

          lines = docStreamReader.ReadToEnd();
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
    public static FileInfo StringToHtmlFile(string strHtml)
    {
      //string tmpPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".htm";
      string tmpPath = @"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\EmailWriterTmp" + Guid.NewGuid().ToString() + ".htm";

      File.WriteAllText(tmpPath, strHtml);

      return new FileInfo(tmpPath);
    }
  }
}
