using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace DataProcessor
{
  public class SQLite
  {
    private string DBPath { get; set; }
    private static void ExecuteQueryString(SQLiteConnection conn, string sql)
    {
      var cmd = new SQLiteCommand(sql, conn);
      cmd.ExecuteNonQuery();
    }
    public void Initialize()
    {
      SQLiteConnection.CreateFile("emailwriterdb.sqlite");
      var conn = new SQLiteConnection("Data Source=emailwriterdb.sqlite;");
      conn.Open();

      string sql = "create table Company " +
        "(Id integer primary key autoincrement, Name varchar(25), Email varchar(50), Address varchar(100), Phone varchar(20))";
      ExecuteQueryString(conn, sql);

      sql = "create table Department " +
        "(Id integer primary key autoincrement, Name varchar(25))";
      ExecuteQueryString(conn, sql);

      sql = "create table TemplateGroup " +
        "(Id integer primary key autoincrement, Name varchar(25), Department_Id integer," +
        "foreign key(Department_Id) references Department(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table Manager " +
        "(Id integer primary key autoincrement, Name varchar(25), Email varchar(50), Phone varchar(20), Rank varchar(20))";
      ExecuteQueryString(conn, sql);

      sql = "create table Template (Id integer primary key autoincrement, Name varchar(25), FileName varchar(255))";
      ExecuteQueryString(conn, sql);

      sql = "create table FileName (Id integer primary key autoincrement, Name varchar(25))";
      ExecuteQueryString(conn, sql);

      sql = "create table CompanyManager (Id integer primary key autoincrement, Company_Id integer, Manager_Id integer," +
        "foreign key(Company_Id) references Company(Id), foreign key(Manager_Id) references Manager(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table CompanyDepartment (Id integer primary key autoincrement, Company_Id integer, Department_Id integer," +
        "foreign key(Company_Id) references Company(Id), foreign key(Department_Id) references Department(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table DepartmentManager (Id integer primary key autoincrement, Department_Id integer, Manager_Id integer," +
        "foreign key(Department_Id) references Department(Id), foreign key(Manager_Id) references Manager(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table DepartmentTemplateGroup (Id integer primary key autoincrement, Department_Id integer, TemplateGroup_Id integer," +
        "foreign key(Department_Id) references Department(Id), foreign key(TemplateGroup_Id) references TemplateGroup(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table TemplateGroupTemplate (Id integer primary key autoincrement, TemplateGroup_Id integer, Template_Id integer," +
        "foreign key(TemplateGroup_Id) references TemplateGroup(Id), foreign key(Template_Id) references Template(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table TemplateFileName (Id integer primary key autoincrement, Template_Id integer, FileName_Id integer," +
        "foreign key(Template_Id) references Template(Id), foreign key(FileName_Id) references FileName(Id))";
      ExecuteQueryString(conn, sql);

      sql = "create table Replacer " +
        "(Id integer primary key autoincrement, Name varchar(50), Location varchar(20), Finder1 varchar(50), Finder2 varchar(50), Finder3 varchar(50))";
      ExecuteQueryString(conn, sql);

      conn.Close();
    }
    public List<string> GetColumn(string tableName, string columnName)
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
    public DataTable GetAllColumns(string tableName)
    {
      var conn = new SQLiteConnection($"Data Source={this.DBPath};");
      conn.Open();

      string sql = $"select * from {tableName}";
      var cmd = new SQLiteCommand(sql, conn);
      SQLiteDataReader rdr = cmd.ExecuteReader();
      DataTable dt = new DataTable();
      dt.Load(rdr);
      rdr.Close();
      conn.Close();

      return dt;
    }
    public DataRow GetDataRow(string tableName, string columnName, string findValue)
    {
      DataTable dt = GetAllColumns(tableName);
      return dt.Select($"{columnName} = '{findValue}'").FirstOrDefault();
    }
    public List<string> GetAllNames(string tableName)
    {
      return GetColumn(tableName, "Name");
    }
    private List<string> GetReplacingKeywordFromStrHtml(string strHtml)
    {
      var replacerList = GetAllNames("Replacer");
      return replacerList.Where(r => strHtml.Contains(r)).ToList();
    }
    public List<Replacer> GetSelectedReplacerList(string strHtml)
    {
      //템플릿 없을때 예외처리?
      var replacingKeywords = GetReplacingKeywordFromStrHtml(strHtml);
      var result = new List<Replacer>();
      var conn = new SQLiteConnection($"Data Source={this.DBPath};");
      conn.Open();
      string sql;
      SQLiteCommand cmd = null;
      SQLiteDataReader rdr = null;
      foreach (var keyword in replacingKeywords)
      {
        sql = $"select * from Replacer where Name = '{keyword}'";
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
    public SQLite(string DBPath)
    {
      this.DBPath = DBPath;
    }
  }
}
