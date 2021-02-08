using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor
{
  public class Replacer
  {
    public string Name { get; set; }
    public string Location { get; set; }
    public string Finder1 { get; set; } //In PDF, It means keyword at FileName. In DB, It means TableName. 키워드, 스타트스트링, 엔드스트링으로 변경할것
    public string Finder2 { get; set; }
    public string Finder3 { get; set; }

    public List<Replacer> ReplacerList { get; set; }

    public Dictionary<string,string> GetReplacerDict(string strHtml, List<string> filePathes)
    {
      FileAttacher attachedFiles = new FileAttacher(filePathes);
      var replacingFiles = attachedFiles.GetReplacingFileList(ReplacerList);

      Dictionary<string, string> result = new Dictionary<string, string>();
      foreach (var file in replacingFiles)
      {
        var strPDF = PdfParser.PdfToString(file);
        foreach (var replacer in ReplacerList)
        {
          if (replacer.Finder3 == null)
          {
            result.Add(replacer.Name, PdfParser.TextParserAfterString(strHtml, replacer.Finder2));
          }
          else
          {
            result.Add(replacer.Name, PdfParser.TextParserBetweenString(strHtml, replacer.Finder2, replacer.Finder3));
          }
        }
      }

      return result;
    }
  }
}
