using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor
{
  public class Replacer
  {
    public string Name { get; set; }
    public string Location { get; set; }
    public string Finder1 { get; set; } //In PDF, It means keyword at FileName. In DB, It means TableName.
    public string Finder2 { get; set; }
    public string Finder3 { get; set; }
    
  }
}
