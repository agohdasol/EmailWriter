using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormEmailWriter
{
  public partial class FrmTemplatesEditor : Form
  {
    public FrmTemplatesEditor()
    {
      InitializeComponent();
    }

    private async void BtnSave_Click(object sender, EventArgs e)
    {
      //parse content
      var html = await this.templateEditorWebView.ExecuteScriptAsync("$('#summernote').summernote('code');");
      html = Regex.Unescape(html);
      html = html.Remove(0, 1);
      html = html.Remove(html.Length - 1, 1);

      //save file
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "HTML|*.html";
      saveFileDialog.Title = "Save an HTML File";
      saveFileDialog.ShowDialog();
      if (saveFileDialog.FileName != "")
      {
        using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
        {
          using (StreamWriter w = new StreamWriter(fs, Encoding.Default))
          {
            w.Write(html);
          }
          fs.Close();
        }
      }
    }

    private async void BtnLoad_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "HTML|*.html;*.htm";
      openFileDialog.Title = "Open an HTML File";
      openFileDialog.ShowDialog();
      if (openFileDialog.FileName != "")
      {
        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
        {
          using (StreamReader sr = new StreamReader(fs, Encoding.Default))
          {
            string html = sr.ReadToEnd();
            await this.templateEditorWebView.ExecuteScriptAsync($"$('#summernote').summernote('pasteHTML', `{html}`);");
          }
        }
      }
    }
  }
}
