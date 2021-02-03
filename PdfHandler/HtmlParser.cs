using System;
using System.IO;
using System.Text;

namespace DataProcessor
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
          var endcoingCode = 51949; //euc-kr이면 51949
          Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
          Stream htmlStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
          using (StreamReader docStreamReader = new StreamReader(htmlStream, System.Text.Encoding.GetEncoding(endcoingCode), true))
          {
            htmlStream.Position = 0;
            lines = docStreamReader.ReadToEnd();
          }
        }
        catch (Exception)
        {
          lines = "메일 템플릿 파일이 올바르지 않습니다.";
        }

      }
      else
      {
        lines = "메일 템플릿 파일이 존재하지 않습니다.";
      }
      return lines;
    }
    public static FileInfo StringToHtmlFile(string strHtml)
    {
      string tmpPath = @"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\EmailWriterTmp" + Guid.NewGuid().ToString() + ".htm";

      File.WriteAllText(tmpPath, strHtml);

      return new FileInfo(tmpPath);
    }
  }
}
