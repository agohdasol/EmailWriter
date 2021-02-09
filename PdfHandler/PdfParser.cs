using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
//상업적 이용시 소스코드 공개 라이센스
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DataProcessor
{
  public static class PdfParser
  {
    public static string PdfToString(string fileName)
    {
      StringBuilder text = new StringBuilder();
      if (File.Exists(fileName))
      {
        try
        {
          using (PdfReader pdfReader = new PdfReader(fileName))
          {
            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
              ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
              string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

              currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
              text.Append(currentText);
            }
            pdfReader.Close();
          }
        }
        catch (Exception)
        {
          return "";
        }
      }
      else
      {
        text.Append("File Not Found.");
      }
      return text.ToString();
    }
    public static string TextParserAfterString(string rawText, string startKeyText)
    {
      string result = "";
      if (rawText != null)
      {
        string[] texts = rawText.Split('\n');
        result = texts.FirstOrDefault(s => s.StartsWith(startKeyText));
        if (result != null)
        {
          int found = result.IndexOf(startKeyText);
          result = result.Substring(found + startKeyText.Length).Trim();
        }
        else
        {
          result = "";
        }
      }
      return result;
    }
    public static string TextParserBetweenString(string rawText, string startKeyText, string endKeyText)
    {
      string result = "";
      if (rawText != null)
      {
        result = TextParserAfterString(rawText, startKeyText);
        if (result != null && result != "")
        {
          int found = result.IndexOf(endKeyText);
          result = result.Remove(found).Trim();
        }
        else
        {
          result = "";
        }

      }
      return result;
    }
  }
}
