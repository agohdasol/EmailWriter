using System.Collections.Generic;

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

    public Dictionary<string, string> GetReplacerDict(List<string> filePathes)
    {
      FileAttacher attachedFiles = new FileAttacher(filePathes);
      var replacingFiles = attachedFiles.GetReplacingFileList(ReplacerList);

      Dictionary<string, string> result = new Dictionary<string, string>();
      //딕셔너리 키 중복이 없어야함...
      foreach (var file in replacingFiles)
      {
        var strPDF = PdfParser.PdfToString(file);
        foreach (var replacer in ReplacerList)
        {
          if (replacer.Location == "PDF")
          {
            if (result.ContainsKey(replacer.Name))
            {
              //중복 키 방지
              if (result[replacer.Name] == null || result[replacer.Name] == "")
              {
                result.Remove(replacer.Name); //키가 있으나 밸류가 공백인 경우 다른파일에서 탐색
              }
              else
              {
                continue;
              }
            }
            if (replacer.Finder3 == null || replacer.Finder3 == "")
            {
              result.Add(replacer.Name, PdfParser.TextParserAfterString(strPDF, replacer.Finder2));
            }
            else
            {
              result.Add(replacer.Name, PdfParser.TextParserBetweenString(strPDF, replacer.Finder2, replacer.Finder3));
            }
          }
        }
      }
      foreach(var replacer in ReplacerList)
      {
        if (replacer.Location == "DB")
        {
          if (!result.ContainsKey(replacer.Name))
          {
            result.Add(replacer.Name, "asd");
            //Cbo 내의 내용을 어떻게 가져올건지?
          }
        }
      }

      return result;
    }
  }
}
