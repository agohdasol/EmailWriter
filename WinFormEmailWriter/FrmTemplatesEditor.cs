using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
      var html = await this.templateEditorWebView.ExecuteScriptAsync("$('#summernote').summernote('code');");
      html = Regex.Unescape(html);
      html = html.Remove(0, 1);
      html = html.Remove(html.Length - 1, 1);
    }
  }
}
