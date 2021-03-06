using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormEmailWriter
{
  public partial class FrmDataEditor : Form
  {
    private void InitializeDataGrid(DataGridView dataGridView, string tableName)
    {
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();
      SQLiteCommand cmd = new SQLiteCommand();
      cmd.Connection = conn;
      cmd.CommandText = $"Select * From {tableName}";
      using (SQLiteDataReader dr = cmd.ExecuteReader())
      {
        DataTable dt = new DataTable();
        dt.Load(dr);
        dataGridView.DataSource = dt;
        dr.Close();
      }
      conn.Close();
      //select tg.Id, tg.Name as '템플릿 그룹명', d.Name as '부서명' from TemplateGroup tg 
      //left join DepartmentTemplateGroup dtg on dtg.TemplateGroup_Id = tg.Id 
      //left join Department d on d.Id = dtg.Department_Id;
    }
    private void Update(DataGridView dataGridView, string tableName)
    {
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();
      SQLiteCommand cmd = new SQLiteCommand();
      cmd = conn.CreateCommand();
      cmd.CommandText = string.Format("SELECT * FROM {0}", tableName);
      var adapter = new SQLiteDataAdapter(cmd);
      SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
      DataTable dt = (DataTable)dataGridView.DataSource;
      adapter.Update(dt);
      conn.Close();
    }
    public FrmDataEditor()
    {
      InitializeComponent();
      InitializeDataGrid(dataGridViewCompany, "Company");
      InitializeDataGrid(dataGridViewDepartment, "Department");
      InitializeDataGrid(dataGridViewManager, "Manager");
      InitializeDataGrid(dataGridViewTemplateGroup, "TemplateGroup");
      InitializeDataGrid(dataGridViewTemplate, "Template");
      InitializeDataGrid(dataGridViewFileName, "FileName");
      InitializeDataGrid(dataGridViewReplacer, "Replacer");
    }

    private void BtnSave_Click(object sender, System.EventArgs e)
    {
      Update(dataGridViewCompany, "Company");
      Update(dataGridViewDepartment, "Department");
      Update(dataGridViewManager, "Manager");
      Update(dataGridViewTemplateGroup, "TemplateGroup");
      Update(dataGridViewTemplate, "Template");
      Update(dataGridViewFileName, "FileName");
      Update(dataGridViewReplacer, "Replacer");
    }
    private void DeleteSelectedRow(DataGridView dataGridView)
    {
      if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
      {
        try
        {
          dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
        }
        catch
        {

        }
      }
    }
    private void BtnDeleteCompanyRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewCompany);
    }
    private void BtnDeleteDepartmentRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewDepartment);
    }

    private void BtnDeleteManagerRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewManager);
    }

    private void BtnDeleteTemplateGroupRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewTemplateGroup);
    }

    private void BtnDeleteTemplateRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewTemplate);
    }

    private void BtnDeleteReplacerRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewReplacer);
    }

    private void BtnDeleteFileNameRow_Click(object sender, System.EventArgs e)
    {
      DeleteSelectedRow(dataGridViewFileName);
    }
  }
}
