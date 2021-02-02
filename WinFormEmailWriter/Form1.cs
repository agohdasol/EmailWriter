using FileHandler;
using System;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace WinFormEmailWriter
{
  public partial class FrmMailWriter : Form
  {
    public FrmMailWriter()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void BtnAddFile_Click(object sender, EventArgs e)
    {
      string html = HtmlParser.HtmlToString(@"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\asd.htm");
      FileInfo tmpFile = HtmlParser.StringToHtmlFile(html);
      PreviewWebBrowser.Navigate(tmpFile.FullName);
      //PreviewWebBrowser.DocumentText = html;
      //PreviewWebBrowser.Document.Encoding = Encoding.GetEncoding("euc-kr").ToString(); //GetEncoding("ks_c_5601-1987").ToString();
    }
  }
}
