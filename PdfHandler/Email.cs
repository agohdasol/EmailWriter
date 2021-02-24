using Microsoft.Office.Interop.Outlook;
using System.Collections.Generic;

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
      if (emailList != null)
      {
        return string.Join("; ", emailList);
      }
      else
      {
        return "";
      }
      
    }
    private static string JoinEmails(string emails, List<string> emailList)
    {
      if (string.IsNullOrEmpty(emails))
      {
        return EmailListToString(emailList);
      }
      //기존 메일 수신자 등이 있는 경우(Fw, Re) 포함해서 반환
      return string.Join("; ", emails, EmailListToString(emailList));
    }
    private void Inject(MailItem mailItem)
    {
      mailItem.To = JoinEmails(mailItem.To, this.Receivers);
      mailItem.CC = JoinEmails(mailItem.CC, this.CC);
      mailItem.Subject = this.Subject;
      mailItem.HTMLBody = this.Body;
      if (AttachedFilePathes != null)
      {
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
    }
    public void Write()
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
