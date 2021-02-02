using Parser;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
      string html = HtmlParser.HtmlToString(@"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\OA접수보고.htm");
      var dict = new Dictionary<string, string>()
      {
        { "##출원번호##", "10-2020-0001121" },
        { "##출원인##", "주식회사 테스트" },
      };
      html = AutoFill.ReplaceAll(html, dict);
      PreviewWebBrowser.DocumentText = html;
    }
  }
}
