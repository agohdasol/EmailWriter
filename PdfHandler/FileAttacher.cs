using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataProcessor
{
  public class FileAttacher
  {
    public List<string> FilePathes { get; set; }

    public FileAttacher(string[] filePathes)
    {
      FilePathes = filePathes.ToList<string>();
    }
    public FileAttacher(List<string> filePathes)
    {
      FilePathes = filePathes;
    }
    public List<string> GetReplacingFileList(List<string> strReplacerList)
    {
      return FilePathes.Where(
        f => strReplacerList.Any(
          s => Path.GetFileNameWithoutExtension(f).Contains(s))
        ).ToList();
    }
    public List<string> GetReplacingFileList(List<Replacer> replacers)
    {
      var replacerList = replacers.Select(r => r.Finder1).ToList();
      return GetReplacingFileList(replacerList);
    }
  }
}
