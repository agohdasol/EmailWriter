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
      //this.PreviewWebBrowser.Navigate(@"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\검토의견.htm");
    }

    private void BtnAddFile_Click(object sender, EventArgs e)
    {
      string html = HtmlParser.HtmlToString(@"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\검토의견.htm");
      //PreviewWebBrowser.DocumentText = html;  //출력 시 인코딩문제 : https://doitforyou.tistory.com/37
      Stream docStream = PreviewWebBrowser.DocumentStream;
      StreamWriter docStreamWriter = new StreamWriter(docStream, System.Text.Encoding.GetEncoding(PreviewWebBrowser.Document.Encoding));
      docStream.Position = 0;
      docStreamWriter.WriteLine(html);
    }
  }
}
