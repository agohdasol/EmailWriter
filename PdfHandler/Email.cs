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
    private void Inject(MailItem mailItem)
    {
      mailItem.To = EmailListToString(this.Receivers);
      mailItem.CC = EmailListToString(this.CC);
      mailItem.Subject = this.Subject;
      mailItem.Body = this.Body;
      try
      {
        foreach (var file in AttachedFilePathes)
        {
          mailItem.Attachments.Add(file);
        }
      }
      catch (System.IO.FileNotFoundException)
      {

      }
    }
    public void Create()
    {
      Application app = new Application();
      MailItem mailItem = (MailItem)app.CreateItem(OlItemType.olMailItem);
      this.Inject(mailItem);
      mailItem.Display(true);
    }
    public void Forward()
    {
      Application app = new Application();
      Selection mySelections = app.ActiveExplorer().Selection;
      foreach (var mySelection in mySelections)  //선택된 다수의 메일에 대해 반복
      {
        MailItem mailItem = (MailItem)mySelection;
        var forwardItem = mailItem.Forward();
        this.Inject(forwardItem);
        forwardItem.Display(true);
      }
    }
    public void ReplyAll()
    {
      Application app = new Application();
      Selection mySelections = app.ActiveExplorer().Selection;
      foreach (var mySelection in mySelections)  //선택된 다수의 메일에 대해 반복
      {
        MailItem mailItem = (MailItem)mySelection;
        var replyItem = mailItem.ReplyAll();
        this.Inject(replyItem);
        replyItem.Display(true);
      }
    }
    public void Reply()
    {
      Application app = new Application();
      Selection mySelections = app.ActiveExplorer().Selection;
      foreach (var mySelection in mySelections)  //선택된 다수의 메일에 대해 반복
      {
        MailItem mailItem = (MailItem)mySelection;
        var replyItem = mailItem.Reply();
        this.Inject(replyItem);
        replyItem.Display(true);
      }
    }
  }
}
