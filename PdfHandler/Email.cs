using System.Collections.Generic;
using Microsoft.Office.Interop.Outlook;

namespace DataProcessor
{
  public class Email
  {
    public List<string> Receivers { get; set; }
    public List<string> CC { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public List<string> AttachedFilePathes { get; set; }
    private static string EmailListToString(List<string> emailList)
    {
      return string.Join("; ", emailList);
    }
    public void CreateNewMail()
    {
      Application app = new Application();
      MailItem mailItem = (MailItem)app.CreateItem(OlItemType.olMailItem);
      mailItem.To = EmailListToString(this.Receivers);
      mailItem.CC = EmailListToString(this.CC);
      mailItem.Subject = this.Subject;
      mailItem.Body = this.Body;
      try
      {
        foreach(var file in AttachedFilePathes)
        {
          mailItem.Attachments.Add(file);
        }
      }
      catch (System.IO.FileNotFoundException)
      {
        
      }
      mailItem.Display(true);
    }
  }
}
