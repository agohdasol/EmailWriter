using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
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
  }
}
