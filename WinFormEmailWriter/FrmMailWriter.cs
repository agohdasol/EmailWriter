using DataProcessor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WinFormEmailWriter
{
  public partial class FrmMailWriter : Form
  {
    public static List<string> Company { get; set; }
    public static List<string> Department { get; set; }
    public static List<string> Manager { get; set; }
    public static List<string> Template { get; set; }
    public static List<string> TemplateGroup { get; set; }
    public static List<string> AttachedFilePathes{ get; set; }
    public FrmMailWriter()
    {
      InitializeComponent();
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
    private void InitializeAttachedFileButton(string[] filePathes)
    {
      int i = 0;
      foreach(var filePath in filePathes)
      {
        Button attachedFileBtn = new Button();
        attachedFileBtn.Text = Path.GetFileName(filePath);
        attachedFileBtn.Name = $"attachedFileBtn{i++}";
        attachedFileBtn.Click += attachedFileBtn_Click;
        //위치조절하여 생성
        PnlAttachedFiles.Controls.Add(attachedFileBtn);
      }
      
    }
    private void attachedFileBtn_Click(object sender, EventArgs e)
    {
      PnlAttachedFiles.Controls.Remove((Button)sender);
    }
    private void BtnAddFile_Click(object sender, EventArgs e)
    {
      using(OpenFileDialog openFileDialog=new OpenFileDialog())
      {
        openFileDialog.Multiselect = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          var filePathes = openFileDialog.FileNames;
          InitializeAttachedFileButton(filePathes);
          //AttachedFilePathes.AddRange(filePathes);
        }
      }
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
    }
    #endregion

    private void BtnWriteMail_Click(object sender, EventArgs e)
    {
      string strHtml = HtmlParser.HtmlToString(@"C:\EmailWriter\WinFormEmailWriter\bin\Debug\netcoreapp3.1\OA접수보고.htm");
      SQLite db = new SQLite("emailwriterdb.sqlite");
      Replacer replacers = new Replacer()
      {
        ReplacerList = db.GetSelectedReplacerList(strHtml)
      };

      List<string> filePathes = new List<string>()
      {
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\20-0489930 등록공보.pdf",
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\20-0489930 의견서.pdf",
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\20-0489930 의견제출통지서.pdf",
        @"\\192.168.123.218\자료실\담당자\황다솔\5. OJT\완료\실용신안\KU_KU20150002705UP-마스크.pdf",
        @"\\192.168.123.218\자료실\incoming\8.IP072208 - A082-6\중간사건\IP072208_의견제출통지서.pdf",
      };

      var dict = replacers.GetReplacerDict(strHtml, filePathes);
      strHtml = AutoFill.ReplaceAll(strHtml, dict);
      PreviewWebBrowser.DocumentText = strHtml;
    }
  }
}
