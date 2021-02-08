using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace DataProcessor
{
  public class SQLite
  {
    private string DBPath { get; set; }
    public List<string> GetAllColumns(string tableName, string columnName)
    {
      var result = new List<string>();
      var conn = new SQLiteConnection($"Data Source={this.DBPath};");
      conn.Open();

      string sql = $"select {columnName} from {tableName}";
      var cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();

      while (rdr.Read())
      {
        result.Add(rdr[columnName].ToString());
      }
      rdr.Close();
      conn.Close();

      return result;
    }
    public List<string> GetAllNames(string tableName)
    {
      return GetAllColumns(tableName, "Name");
    }
    private List<string> GetReplacingKeyword(string strHtml)
    {
      var replacerList = GetAllNames("Replacer");
      return replacerList.Where(r => strHtml.Contains(r)).ToList();
    }
    public List<Replacer> GetSelectedReplacerList(string strHtml)
    {
      var replacingKeywords = GetReplacingKeyword(strHtml);
      var result = new List<Replacer>();
      var conn = new SQLiteConnection($"Data Source={this.DBPath};");
      conn.Open();
      string sql;
      SQLiteCommand cmd = null;
      SQLiteDataReader rdr = null;
      foreach (var keyword in replacingKeywords)
      {
        sql = $"select * from Replacer";
        cmd = new SQLiteCommand(sql, conn);
        rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
          result.Add(
              new Replacer()
              {
                Name = rdr["Name"].ToString(),
                Location = rdr["Location"].ToString(),
                Finder1 = rdr["Finder1"].ToString(),
                Finder2 = rdr["Finder2"].ToString(),
                Finder3 = rdr["Finder3"].ToString(),
              }
            );
        }
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
      string sql = $"select Id from {filteringTableName} where Name = '{filterArgument}'";
      var cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      if (rdr.Read())
      {
        string filterArgumentId = rdr["Id"].ToString();


        //filterArgumentId 값으로 filteredTable 필터링
        sql = $"select Name from {filteredTableName} m " +
          $"left join {filteringTableName}{filteredTableName} cm on cm.{filteredTableName}_Id = m.Id " +
          $"where cm.{filteringTableName}_Id = {filterArgumentId}";
        cmd = new SQLiteCommand(sql, conn);
        rdr = cmd.ExecuteReader();
      }
      while (rdr.Read())
      {
        result.Add(rdr["Name"].ToString());
      }
      rdr.Close();
      conn.Close();

      return result;
    }
    //private static void ExecuteQueryString(SQLiteConnection conn, string sql)
    //{
    //  var cmd = new SQLiteCommand(sql, conn);
    //  cmd.ExecuteNonQuery();
    //}
    public SQLite(string DBPath)
    {
      this.DBPath = DBPath;
    }
  }
}
