using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace DataProcessor
{
  public class SQLite
  {
    private string DBPath { get; set; }
    public List<string> GetAllNames(string tableName)
    {
      var result=new List<string>();
      var conn = new SQLiteConnection($"Data Source={this.DBPath};");
      conn.Open();

      string sql = $"select Name from {tableName}";
      var cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      
      while (rdr.Read())
      {
        result.Add(rdr["Name"].ToString());
      }
      rdr.Close();
      conn.Close();

      return result;
    }
    public List<string> GetFilteredNames(string filteredTableName, string filteringTableName, string filterArgument)
    {
      var result = new List<string>();
      var conn = new SQLiteConnection($"Data Source={this.DBPath};");
      conn.Open();

      //필터링 테이블에서 필터아규먼트의 Id값 반환
      string sql = $"select id from {filteringTableName} where name = '{filterArgument}'";
      var cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      string filterArgumentId = rdr["Id"].ToString();

      //filterArgumentId 값으로 filteredTable 필터링
      sql = $"select Name from {filteredTableName} m " +
        $"left join {filteringTableName}{filteredTableName} cm on cm.{filteredTableName}_Id = m.Id " +
        $"where cm.{filteringTableName}_Id = {filterArgumentId}";
      cmd = new SQLiteCommand(sql, conn);
      rdr = cmd.ExecuteReader();

      while (rdr.Read())
      {
        result.Add(rdr["Name"].ToString());
      }
      rdr.Close();
      conn.Close();

      return result;
    }
    private static void ExecuteQueryString(SQLiteConnection conn, string sql)
    {
      var cmd = new SQLiteCommand(sql, conn);
      cmd.ExecuteNonQuery();
    }
    public static void SQLiteInitializer()
    {

    }
    public SQLite(string DBPath)
    {
      this.DBPath = DBPath;
    }
  }
}
