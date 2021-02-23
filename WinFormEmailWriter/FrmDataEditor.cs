using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormEmailWriter
{
  public partial class FrmDataEditor : Form
  {
    //public FrmDataEditor()
    //{
    //  InitializeComponent();
    //}
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

    private void BtnDeleteRow_Click(object sender, System.EventArgs e)
    {
      dataGridViewCompany.Rows.Remove(dataGridViewCompany.SelectedRows[0]);
    }
  }
}
