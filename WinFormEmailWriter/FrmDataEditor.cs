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
    public FrmDataEditor()
    {
      InitializeComponent();
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();
      SQLiteCommand cmd = new SQLiteCommand();
      cmd.Connection = conn;
      cmd.CommandText = "Select * From Company";
      using (SQLiteDataReader dr = cmd.ExecuteReader())
      {
        DataTable dt = new DataTable();
        dt.Load(dr);
        dr.Close();
        conn.Close();
        dataGridView.DataSource = dt;
      }
    }
  }
}
