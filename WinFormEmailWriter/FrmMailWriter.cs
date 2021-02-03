using DataProcessor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormEmailWriter
{
  public partial class FrmMailWriter : Form
  {
    public static List<string> Company { get; set; }
    public static List<string> Department { get; set; }
    public static List<string> Manager { get; set; }
    public static List<string> Template { get; set; }
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
      for(int i=0; i<cboList.Count; i++)
      {
        // 바뀐 콤보박스의 다음 콤보박스부터 초기화
        if (startChecker)
        {
          cboList[i].Items.Clear();
          itemList = ComboBoxFilter(cboList[i-1], cboList[i].Name.ToString().Replace("Cbo", ""), cboList[i-1].Name.ToString().Replace("Cbo", ""));
          ComboBoxItemAdder(cboList[i], itemList);
        }
        if (changedComboBox == cboList[i])
        {
          startChecker = true;
        }
      }
    }
    private static void GetDataForComboBox()
    {
      SQLite db = new SQLite("emailwriterdb.sqlite");
      Company = db.GetAllNames("Company");
      Department = db.GetAllNames("Department");
      Manager = db.GetAllNames("Manager");
      Template = db.GetAllNames("Template");
    }
    private static void ComboBoxItemAdder(ComboBox comboBox, List<string> data)
    {
      if (data != null)
      {
        comboBox.Items.AddRange(data.ToArray());
      }
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

    private void CboCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxInitializer(CboCompany);
    }
  }
}
