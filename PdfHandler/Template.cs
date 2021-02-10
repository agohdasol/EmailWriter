using System.Collections.Generic;
using System.Data;

namespace DataProcessor
{
  public class Template
  {
    public DataRow Company { get; set; }
    public DataRow Department { get; set; }
    public DataRow TemplateGroup { get; set; }
    public DataRow Name { get; set; }
    public string GetTemplateName()
    {
      return Name["FileName"].ToString();
    }
  }
}
