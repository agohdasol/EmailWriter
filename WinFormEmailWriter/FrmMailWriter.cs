using DataProcessor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormEmailWriter
{
  public partial class FrmMailWriter : Form
  {
    public static List<string> Company { get; set; }
    public static List<string> Department { get; set; }
    public static List<string> Manager { get; set; }
    public static List<string> Template { get; set; }
    public static List<string> TemplateGroup { get; set; }
    public static Dictionary<Button, string> AttachedFiles { get; set; } = new Dictionary<Button, string>();
    public static Template SelectedTemplate { get; set; }
    public FrmMailWriter()
    {
      InitializeComponent();
    }
    private static List<string> GetAttachedFilesList()
    {
      return new List<string>(AttachedFiles.Values);
    }
    private void FrmMailWriter_Load(object sender, EventArgs e)
    {
      GetDataForComboBox();
      ComboBoxInitializer(CboCompany);
      CboCompany.Items.Clear();
      ComboBoxItemAdder(CboCompany, Company);
    }
    private List<string> ComboBoxFilter(ComboBox upperComboBox, string filteredTableName, string filteringTableName)
    {
      SQLite db = new SQLite("emailwriterdb.sqlite");
      if (upperComboBox.SelectedItem != null)
      {
        return db.GetFilteredNames(filteredTableName, filteringTableName, upperComboBox.SelectedItem.ToString());
      }
      else
      {
        return null;
      }
    }
    private void ComboBoxInitializer(ComboBox changedComboBox)
    {
      List<ComboBox> cboList = new List<ComboBox>()
      {
        CboCompany, CboDepartment, CboManager, CboTemplateGroup, CboTemplate
      };

      bool startChecker = false;
      List<string> itemList;
      for (int i = 0; i < cboList.Count; i++)
      {
        // 바뀐 콤보박스의 다음 콤보박스부터 초기화
        if (startChecker)
        {
          cboList[i].SelectedIndex = -1;
          cboList[i].Items.Clear();
          if (changedComboBox == CboManager && cboList[i] == CboTemplateGroup)
          {
            itemList = ComboBoxFilter(CboDepartment, "TemplateGroup", "Department");
          }
          else
          {
            itemList = ComboBoxFilter(cboList[i - 1], cboList[i].Name.ToString().Replace("Cbo", ""), cboList[i - 1].Name.ToString().Replace("Cbo", ""));
          }
          ComboBoxItemAdder(cboList[i], itemList);
        }
        if (changedComboBox == cboList[i])
        {
          startChecker = true;
        }
      }
      startChecker = false;
    }
    private static void GetDataForComboBox()
    {
      SQLite db = new SQLite("emailwriterdb.sqlite");
      Company = db.GetAllNames("Company");
      Department = db.GetAllNames("Department");
      Manager = db.GetAllNames("Manager");
      TemplateGroup = db.GetAllNames("TemplateGroup");
      Template = db.GetAllNames("Template");
    }
    private static void ComboBoxItemAdder(ComboBox comboBox, List<string> data)
    {
      if (data != null)
      {
        comboBox.Items.AddRange(data.ToArray());
      }
    }
    private void AddAttachedFileButton(List<string> filePathes)
    {
      foreach (var filePath in filePathes)
      {
        Button attachedFileBtn = new Button();
        attachedFileBtn.Text = Path.GetFileName(filePath);
        attachedFileBtn.Click += attachedFileBtn_Click;
        attachedFileBtn.AutoSizeMode = AutoSizeMode.GrowOnly;
        attachedFileBtn.AutoSize = true;
        FLPAttachedFiles.Controls.Add(attachedFileBtn);
        AttachedFiles.Add(attachedFileBtn, filePath);
      }
    }
    private void attachedFileBtn_Click(object sender, EventArgs e)
    {
      AttachedFiles.Remove((Button)sender);
      FLPAttachedFiles.Controls.Remove((Button)sender);
    }
    private void BtnAddFile_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Multiselect = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          var filePathes = openFileDialog.FileNames.Where(f => !GetAttachedFilesList().Contains(f)).ToList();
          AddAttachedFileButton(filePathes);
          GetAttachedFilesList().AddRange(filePathes);
        }
      }
    }
    private void BtnRemoveAllFiles_Click(object sender, EventArgs e)
    {
      AttachedFiles.Clear();
      FLPAttachedFiles.Controls.Clear();
    }
    #region Change ComboBox
    private void CboCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxInitializer(CboCompany);
    }

    private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxInitializer(CboDepartment);
    }

    private void CboManager_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxInitializer(CboManager);
    }

    private void CboTemplateGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxInitializer(CboTemplateGroup);
    }

    private void CboTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxInitializer(CboTemplate);
      SQLite db = new SQLite("emailwriterdb.sqlite");
      SelectedTemplate = new Template()
      {
        Company = db.GetDataRow("Company", "Name", CboCompany.Text),
        Department = db.GetDataRow("Department", "Name", CboDepartment.Text),
        TemplateGroup = db.GetDataRow("TemplateGroup", "Name", CboTemplateGroup.Text),
        Name = db.GetDataRow("Template", "Name", CboTemplate.Text),
      };
    }
    #endregion

    private void BtnWriteMail_Click(object sender, EventArgs e)
    {
      SQLite db = new SQLite("emailwriterdb.sqlite");
      var templateFilePath = SelectedTemplate.GetTemplateName();
      string strHtml = HtmlParser.HtmlToString(templateFilePath);
      Replacer replacers = new Replacer()
      {
        ReplacerList = db.GetSelectedReplacerList(strHtml)
      };
      var dict = new Dictionary<string, string>();
      if (AttachedFiles != null)
      {
        dict = replacers.GetReplacerDict(strHtml, GetAttachedFilesList());
      }
      strHtml = AutoFill.ReplaceAll(strHtml, dict);
      PreviewWebBrowser.DocumentText = strHtml;
    }
  }
}
