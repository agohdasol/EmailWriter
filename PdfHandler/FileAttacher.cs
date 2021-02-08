using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataProcessor
{
  public class FileAttacher
  {
    public List<string> FilePathes { get; set; }

    public FileAttacher(List<string> filePathes)
    {
      FilePathes = filePathes;
    }
    public List<string> GetReplacingFileList(List<string> replacerList)
    {
      return FilePathes.Where(
        f => replacerList.Any(
          s => Path.GetFileNameWithoutExtension(f).Contains(s))
        ).ToList();
    }
  }
}
