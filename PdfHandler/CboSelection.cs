using System.Collections.Generic;
using System.Data;

namespace DataProcessor
{
  public class CboSelection
  {
    public DataRow Company { get; set; }
    public DataRow Department { get; set; }
    public DataRow Manager { get; set; }
    public DataRow TemplateGroup { get; set; }
    public DataRow TemplateName { get; set; }
    public string GetTemplateName()
    {
      return TemplateName["FileName"].ToString();
    }
  }
}
